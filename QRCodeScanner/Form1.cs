using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ZXing;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Threading.Tasks;
using static QRCodeScanner.students;
using System.IO;
using System.Linq;
using static QRCodeScanner.students.Student;
using Guna.UI2.WinForms;


namespace QRCodeScanner
{
    public partial class Form1 : Form
    {
        SqlConnection connectionString = new SqlConnection(@"Data Source=.\MSSQLSERVER2024;Initial Catalog=FinalDb;Integrated Security=True");






        private BarcodeReader barcodeReader;
        private VideoCaptureDevice finalFrame;
        private FilterInfoCollection captureDevice;

        private Size formOriginalSize;
        private Rectangle photoBox; //Photo
        private Rectangle studentIDNumbertxtBox; //IDNumber

        private Rectangle panel1Box;
        private Rectangle subjectCodeLabel;
        private Rectangle subjectCodetxtBox;


        private Rectangle panel2Box;
        private Rectangle firstnameLabel;
        private Rectangle firstnametxtBox;

        private Rectangle layoutPanel1;
        private Rectangle layoutPanel2;
        private Rectangle layoutPanel3;

        private Rectangle layoutPanel4;

        public Form1()
        {
            InitializeComponent();

            panel3.MouseDown += panel3_MouseDown;
            panel3.MouseMove += panel3_MouseMove;
            panel3.MouseUp += panel3_MouseUp;

            barcodeReader = new BarcodeReader();
            captureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            StartCamera();

            // Attach the FormClosing event handler
            btnCloseBox.Click += btnCloseBox_Click;


            this.Resize += Form1_Resize;
            formOriginalSize = this.Size;

            // Capture initial sizes and locations of controls

            //Photo
            photoBox = new Rectangle(Photo.Location, Photo.Size);
            //Student ID Number
            studentIDNumbertxtBox = new Rectangle(txtIDNumber.Location, txtIDNumber.Size);


            //Panel 1
            panel1Box = new Rectangle(panel1.Location, panel1.Size);
            //Panel 1 Contents
            // subjectCodeLabel = new Rectangle(guna2HtmlLabel1.Location, guna2HtmlLabel1.Size);
            // subjectCodetxtBox = new Rectangle(guna2TextBox1.Location, guna2TextBox1.Size);



            //Panel 2 
            panel2Box = new Rectangle(panel2.Location, panel2.Size);
            //Panel 2 Contents
            //firstnameLabel = new Rectangle(guna2HtmlLabel1.Location, guna2HtmlLabel1.Size);
            //firstnametxtBox = new Rectangle(guna2TextBox1.Location, guna2TextBox1.Size);

            //layout1
            layoutPanel1 = new Rectangle(panel5.Location, panel5.Size);
            //layout2
            layoutPanel2 = new Rectangle(tableLayoutPanel2.Location, tableLayoutPanel2.Size);
            //layout3
            layoutPanel3 = new Rectangle(tableLayoutPanel3.Location, tableLayoutPanel3.Size);


            layoutPanel4 = new Rectangle(tableLayoutPanel1.Location, tableLayoutPanel1.Size);





            //---------------------------------------------------------------------------




            //---------------------------------------------------------------------------

        }


        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point difference = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(difference));
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // Resize controls during form resize event
            resize_Control(Photo, photoBox);
            resize_Control(txtIDNumber, studentIDNumbertxtBox);
            
          //  resize_Control(guna2HtmlLabel1, subjectCodeLabel);
             // resize_Control(guna2TextBox1, subjectCodetxtBox);


            resize_Control(panel2, panel2Box);
            resize_Control(label4, firstnameLabel);
            //resize_Control(txtFirstName, firstnametxtBox);


            resize_Control(panel1, panel1Box);
            resize_Control(panel5, layoutPanel1);
            resize_Control(tableLayoutPanel2, layoutPanel2);


            resize_Control(tableLayoutPanel3, layoutPanel3);


            resize_Control(tableLayoutPanel1, layoutPanel4);

        }
        private void resize_Control(System.Windows.Forms.Control c, Rectangle r)
        {
            // Calculate new size and location based on form's new size
            float xRatio = (float)this.Width / formOriginalSize.Width;
            float yRatio = (float)this.Height / formOriginalSize.Height;

            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);
            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            // Update the control's location and size
            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }


        private void StartCamera()
        {
            try
            {
                if (captureDevice.Count == 0)
                {
                    MessageBox.Show("No camera devices found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                finalFrame = new VideoCaptureDevice(captureDevice[0].MonikerString);
                finalFrame.NewFrame += FinalFrame_NewFrame;
                finalFrame.Start();

                timer1.Start(); // Start the timer for continuous decoding
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error starting camera: {ex.Message}", "Camera Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Bitmap ResizeImage(Bitmap image, Size newSize)
        {
            Bitmap resizedImage = new Bitmap(newSize.Width, newSize.Height);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.DrawImage(image, new Rectangle(Point.Empty, newSize));
            }
            return resizedImage;
        }

        private string DecodeQRCode(Bitmap image)
        {
            try
            {
                // Decode QR Code
                Result result = barcodeReader.Decode(image);

                // Check if result is not null
                if (result != null)
                {
                    return result.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error decoding QR code: {ex.Message}", "QR Code Decoding Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null; // Return null if QR code could not be decoded
        }
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // Resize the captured frame to a smaller size
            Bitmap capturedFrame = ResizeImage((Bitmap)eventArgs.Frame.Clone(), new Size(239, 185));

            // Decode QR code
            string qrText = DecodeQRCode(capturedFrame);

            // Check if QR code is decoded successfully
            if (!string.IsNullOrEmpty(qrText))
            {
                // Autopopulate TextBox with QR code information on the UI thread
                txtIDNumber.Invoke(new Action(() => { txtIDNumber.Text = qrText; }));
            }

            // Process the scanned QR code
            ProcessQRCodeScan(capturedFrame);

            // Display the captured frame in pictureBox1
            pictureBox1.Image = capturedFrame;
        }

        private void RecordTimeIn(int IDNumber, string Firstname, string Lastname)
        {
            try
            {
                // Open the database connection
                connectionString.Open();

                // Execute the stored procedure to record time in
                using (SqlCommand command = new SqlCommand("RecordTimeIn", connectionString))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IDNumber", IDNumber);
                    command.Parameters.AddWithValue("@Firstname", Firstname);
                    command.Parameters.AddWithValue("@Lastname", Lastname);

                    // Convert current time to 12-hour format string
                    string timeInFormatted = DateTime.Now.ToString("hh:mm:ss tt");
                    command.Parameters.AddWithValue("@TimeIn", timeInFormatted);

                    // Add output parameter for message
                    SqlParameter messageParam = new SqlParameter("@Message", SqlDbType.NVarChar, 100);
                    messageParam.Direction = ParameterDirection.Output;
                    command.Parameters.Add(messageParam);

                    command.ExecuteNonQuery();

                    // Retrieve the message from the output parameter
                    string message = command.Parameters["@Message"].Value.ToString();

                    // Display the message in labelNotification

                    labelNotification.Invoke(new Action(() => labelNotification.Text = message));
                    labelNotification.ForeColor = Color.Red;
                }

                // After recording time in, fetch attendance data and display it
                DisplayAttendanceData(IDNumber);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Time In Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the database connection
                connectionString.Close();
            }
        }

        private void DisplayAttendanceData(int IDNumber)
        {
            // Query to fetch the most recent entry for the student from the Attendance table
            string query = "SELECT TOP 1 Title, SubjectCode, Schedule, enrollmentStatus,TimeIn, TimeOut " +
                           "FROM Attendance " +
                           "WHERE IDNumber = @IDNumber " +
                           "ORDER BY AttendanceID DESC, TimeIn DESC";

            using (SqlCommand command = new SqlCommand(query, connectionString))
            {
                command.Parameters.AddWithValue("@IDNumber", IDNumber);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Read the enrollment status and other details
                        string enrollmentStatus = reader["enrollmentStatus"].ToString();
                        string subjectCode = reader["SubjectCode"].ToString();
                        string schedule = reader["Schedule"].ToString();
                        string title = reader["Title"].ToString();

                        // Check if the student has already timed in
                        bool isTimedIn = !string.IsNullOrEmpty(reader["TimeIn"].ToString());

                        //Verify if student already timed in
                        if (isTimedIn)
                        {
                            // Student already timed in and need to time out
                            if (reader["TimeOut"] != DBNull.Value)
                            {
                                // Display common fields
                                txtSubjectCode.Invoke(new Action(() => txtSubjectCode.Text = subjectCode));
                                txtSchedule.Invoke(new Action(() => txtSchedule.Text = schedule));
                                txtDescriptiveTitle.Invoke(new Action(() => txtDescriptiveTitle.Text = title));
                                txtEnrollmentStatus.Invoke(new Action(() =>
                                {
                                    txtEnrollmentStatus.Text = enrollmentStatus;
                                    if (enrollmentStatus == "Present")
                                    {
                                        txtEnrollmentStatus.FillColor = Color.Green;
                                        txtEnrollmentStatus.ForeColor = Color.White;
                                        txtEnrollmentStatus.Font = new Font(txtEnrollmentStatus.Font, FontStyle.Bold);
                                    }
                                    else if (enrollmentStatus == "Late")
                                    {
                                        txtEnrollmentStatus.FillColor = Color.Orange;
                                        txtEnrollmentStatus.ForeColor = Color.White;
                                        txtEnrollmentStatus.Font = new Font(txtEnrollmentStatus.Font, FontStyle.Bold);
                                    }
                                    else if (enrollmentStatus == "Not Enrolled")
                                    {
                                        txtEnrollmentStatus.FillColor = Color.Red;
                                        txtEnrollmentStatus.ForeColor = Color.White;
                                        txtEnrollmentStatus.Font = new Font(txtEnrollmentStatus.Font, FontStyle.Bold);
                                    }
                                    else
                                    {
                                        txtEnrollmentStatus.FillColor = Color.White;
                                        txtEnrollmentStatus.ForeColor = Color.Black;
                                        txtEnrollmentStatus.Font = new Font(txtEnrollmentStatus.Font, FontStyle.Bold);
                                    }
                                }));

                                //Time In data
                                DateTime timeIn = DateTime.Parse(reader["TimeIn"].ToString());
                                string formattedTimeIn = timeIn.ToString("hh:mm tt");
                                txtTimeIn.Invoke(new Action(() => txtTimeIn.Text = formattedTimeIn));

                                //Time Out data
                                DateTime timeOut = DateTime.Parse(reader["TimeOut"].ToString());
                                string formattedTimeOut = timeOut.ToString("hh:mm tt");
                                // Display the formatted time in txtTimeIn TextBox
                                txtTimeOut.Invoke(new Action(() => txtTimeOut.Text = formattedTimeOut));
                            }
                            //Timed in but not ready to time out
                            else
                            {
                                // Display common fields
                                txtSubjectCode.Invoke(new Action(() => txtSubjectCode.Text = subjectCode));
                                txtSchedule.Invoke(new Action(() => txtSchedule.Text = schedule));
                                txtDescriptiveTitle.Invoke(new Action(() => txtDescriptiveTitle.Text = title));
                                txtEnrollmentStatus.Invoke(new Action(() =>
                                {
                                    txtEnrollmentStatus.Text = enrollmentStatus;
                                    if (enrollmentStatus == "Present")
                                    {
                                        txtEnrollmentStatus.FillColor = Color.Green;
                                        txtEnrollmentStatus.ForeColor = Color.White;
                                        txtEnrollmentStatus.Font = new Font(txtEnrollmentStatus.Font, FontStyle.Bold);
                                    }
                                    else if (enrollmentStatus == "Late")
                                    {
                                        txtEnrollmentStatus.FillColor = Color.Orange;
                                        txtEnrollmentStatus.ForeColor = Color.White;
                                        txtEnrollmentStatus.Font = new Font(txtEnrollmentStatus.Font, FontStyle.Bold);
                                    }
                                    else if (enrollmentStatus == "Not Enrolled")
                                    {
                                        txtEnrollmentStatus.FillColor = Color.Red;
                                        txtEnrollmentStatus.ForeColor = Color.White;
                                        txtEnrollmentStatus.Font = new Font(txtEnrollmentStatus.Font, FontStyle.Bold);
                                    }
                                    else
                                    {
                                        txtEnrollmentStatus.FillColor = Color.White;
                                        txtEnrollmentStatus.ForeColor = Color.Black;
                                        txtEnrollmentStatus.Font = new Font(txtEnrollmentStatus.Font, FontStyle.Bold);
                                    }
                                }));

                                //Time In data
                                DateTime timeIn = DateTime.Parse(reader["TimeIn"].ToString());
                                string formattedTimeIn = timeIn.ToString("hh:mm tt");
                                txtTimeIn.Invoke(new Action(() => txtTimeIn.Text = formattedTimeIn));

                                // Student has not timed in yet
                                txtTimeOut.Invoke(new Action(() => txtTimeOut.Text = ""));
                            }
                        }
                        else
                        {
                            // Display common fields
                            txtSubjectCode.Invoke(new Action(() => txtSubjectCode.Text = subjectCode));
                            txtSchedule.Invoke(new Action(() => txtSchedule.Text = schedule));
                            txtDescriptiveTitle.Invoke(new Action(() => txtDescriptiveTitle.Text = title));
                            txtEnrollmentStatus.Invoke(new Action(() =>
                            {
                                txtEnrollmentStatus.Text = enrollmentStatus;
                                if (enrollmentStatus == "Present")
                                {
                                    txtEnrollmentStatus.FillColor = Color.Green;
                                    txtEnrollmentStatus.ForeColor = Color.White;
                                    txtEnrollmentStatus.Font = new Font(txtEnrollmentStatus.Font, FontStyle.Bold);
                                }
                                else if (enrollmentStatus == "Late")
                                {
                                    txtEnrollmentStatus.FillColor = Color.Orange;
                                    txtEnrollmentStatus.ForeColor = Color.White;
                                    txtEnrollmentStatus.Font = new Font(txtEnrollmentStatus.Font, FontStyle.Bold);
                                }
                                else if (enrollmentStatus == "Not Enrolled")
                                {
                                    txtEnrollmentStatus.FillColor = Color.Red;
                                    txtEnrollmentStatus.ForeColor = Color.White;
                                    txtEnrollmentStatus.Font = new Font(txtEnrollmentStatus.Font, FontStyle.Bold);
                                }
                                else
                                {
                                    txtEnrollmentStatus.FillColor = Color.White;
                                    txtEnrollmentStatus.ForeColor = Color.Black;
                                    txtEnrollmentStatus.Font = new Font(txtEnrollmentStatus.Font, FontStyle.Bold);
                                }
                            }));

                            DateTime timeIn = DateTime.Parse(reader["TimeIn"].ToString());
                            string formattedTimeIn = timeIn.ToString("hh:mm tt");
                            txtTimeIn.Invoke(new Action(() => txtTimeIn.Text = formattedTimeIn));

                            // Student has not timed in yet
                            txtTimeOut.Invoke(new Action(() => txtTimeOut.Text = ""));
                        }

                        // If the student is not enrolled, display "Not Enrolled" status
                        if (enrollmentStatus != "Present" && enrollmentStatus != "Late" && enrollmentStatus != "Absent")
                        {
                            DateTime timeOut = DateTime.Parse(reader["TimeOut"].ToString());
                            string formattedTimeOut = timeOut.ToString("hh:mm tt");
                            // Display the formatted time in txtTimeIn TextBox
                            txtTimeOut.Invoke(new Action(() => txtTimeOut.Text = formattedTimeOut));

                            txtDescriptiveTitle.Invoke(new Action(() => txtDescriptiveTitle.Text = ""));
                            txtSubjectCode.Invoke(new Action(() => txtSubjectCode.Text = ""));
                            txtSchedule.Invoke(new Action(() => txtSchedule.Text = ""));                            

                            txtEnrollmentStatus.Invoke(new Action(() =>
                            {
                                txtEnrollmentStatus.Text = enrollmentStatus;
                                if (enrollmentStatus == "Present")
                                {
                                    txtEnrollmentStatus.FillColor = Color.Green;
                                    txtEnrollmentStatus.ForeColor = Color.White;
                                    txtEnrollmentStatus.Font = new Font(txtEnrollmentStatus.Font, FontStyle.Bold);
                                }
                                else if (enrollmentStatus == "Late")
                                {
                                    txtEnrollmentStatus.FillColor = Color.Orange;
                                    txtEnrollmentStatus.ForeColor = Color.White;
                                    txtEnrollmentStatus.Font = new Font(txtEnrollmentStatus.Font, FontStyle.Bold);
                                }
                                else if (enrollmentStatus == "Not Enrolled")
                                {
                                    txtEnrollmentStatus.Text = enrollmentStatus + " at this time";
                                    txtEnrollmentStatus.FillColor = Color.Red;
                                    txtEnrollmentStatus.ForeColor = Color.White;
                                    txtEnrollmentStatus.Font = new Font(txtEnrollmentStatus.Font, FontStyle.Bold);
                                }
                                else
                                {
                                    txtEnrollmentStatus.FillColor = Color.White;
                                    txtEnrollmentStatus.ForeColor = Color.Black;
                                    txtEnrollmentStatus.Font = new Font(txtEnrollmentStatus.Font, FontStyle.Bold);
                                }
                            }));
                        }
                    }
                    else
                    {
                        // Populate the TextBoxes with student information
                        Photo.Image = null;
                        txtIDNumber.Invoke(new Action(() => txtIDNumber.Text = ""));
                        txtFirstName.Invoke(new Action(() => txtFirstName.Text = ""));
                        txtLastName.Invoke(new Action(() => txtLastName.Text = ""));
                        txtGender.Invoke(new Action(() => txtGender.Text = ""));
                        txtCourse.Invoke(new Action(() => txtCourse.Text = ""));
                        txtYear.Invoke(new Action(() => txtYear.Text = ""));
                        txtSchoolYear.Invoke(new Action(() => txtSchoolYear.Text = ""));
                        txtSemester.Invoke(new Action(() => txtSemester.Text = ""));
                        txtDescriptiveTitle.Invoke(new Action(() => txtDescriptiveTitle.Text = ""));
                        txtSubjectCode.Invoke(new Action(() => txtSubjectCode.Text = ""));
                        txtSchedule.Invoke(new Action(() => txtSchedule.Text = ""));
                        txtEnrollmentStatus.Invoke(new Action(() => txtEnrollmentStatus.Text = ""));

                        //Time
                        txtTimeIn.Invoke(new Action(() => txtTimeIn.Text = ""));
                        txtTimeOut.Invoke(new Action(() => txtTimeOut.Text = ""));

                        txtDescriptiveTitle.Invoke(new Action(() => txtDescriptiveTitle.Text = "No Student Account Found"));
                        labelNotification.Invoke(new Action(() => labelNotification.Text = ""));
                    }
                }
            }
        }

        private void RecordTimeOut(int IDNumber)
        {
            try
            {
                // Open the database connection
                connectionString.Open();

                // Check if a record exists with the given IDNumber and a null TimeOut
                string query = "SELECT COUNT(*) FROM Attendance WHERE IDNumber = @IDNumber AND TimeOut IS NULL";
                using (SqlCommand command = new SqlCommand(query, connectionString))
                {
                    command.Parameters.AddWithValue("@IDNumber", IDNumber);
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        // If a record exists, update the TimeOut
                        using (SqlCommand updateCommand = new SqlCommand("UPDATE Attendance SET TimeOut = @TimeOut WHERE IDNumber = @IDNumber AND TimeOut IS NULL AND enrollmentStatus != 'Absent'", connectionString))
                        {
                            updateCommand.Parameters.AddWithValue("@IDNumber", IDNumber);


                            // Convert current time to 12-hour format string
                            // Convert current time to 12-hour format string
                            string timeOutFormatted = DateTime.Now.ToString("hh:mm:ss tt");
                            updateCommand.Parameters.AddWithValue("@TimeOut", timeOutFormatted);
                            updateCommand.ExecuteNonQuery();
                        }
                        DisplayAttendanceData(IDNumber);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Time Out Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the database connection
                connectionString.Close();
            }
        }

        private async void ProcessQRCodeScan(Bitmap capturedFrame)
        {
            string IDNumber = DecodeQRCode(capturedFrame);

            if (!string.IsNullOrEmpty(IDNumber))
            {
                int IDNumberInt;
                if (int.TryParse(IDNumber, out IDNumberInt))
                {
                    // Fetch student information from the database
                    Student student = GetStudentInfo(IDNumberInt);

                    if (student != null)
                    {
                        // Populate the TextBoxes with student information                        
                        txtFirstName.Invoke(new Action(() => txtFirstName.Text = student.Firstname));
                        txtLastName.Invoke(new Action(() => txtLastName.Text = student.Lastname));
                        txtGender.Invoke(new Action(() => txtGender.Text = student.Gender));
                        txtCourse.Invoke(new Action(() => txtCourse.Text = student.Course));
                        txtYear.Invoke(new Action(() => txtYear.Text = student.Year));
                        txtSchoolYear.Invoke(new Action(() => txtSchoolYear.Text = student.SchoolYear));
                        txtSemester.Invoke(new Action(() => txtSemester.Text = student.Semester));

                        // You can also display the student's photo if available
                        // Display the student's photo if available
                        if (student.Photo != null && student.Photo.Length > 0)
                        {
                            Photo.Invoke(new Action(() => Photo.Image = Image.FromStream(new MemoryStream(student.Photo))));
                        }
                        else
                        {
                            // Handle the case where the photo is not available
                            // For example, you can display a default photo or leave it blank
                            // picStudentPhoto.Image = defaultPhoto;
                            // or
                            // Photo.Image = null;
                        }


                        // Record time in or time out as needed
                        Student enrollmentDetails = VerifyStudentEnrollment(IDNumberInt);

                        //Doesnt accept previous absent. accepts present. accepts late. 


                        if (IsStudentTimedIn(IDNumberInt))
                        {
                            //check if student attempts to time out before the end of the sub.
                            if (CanTimeOut(IDNumberInt))
                            {
                                labelNotification.Invoke(new Action(() => labelNotification.Text = ""));
                                RecordTimeOut(IDNumberInt);
                            }
                        }
                        else
                        {
                            if (enrollmentDetails != null && enrollmentDetails.enrollmentStatus != "Absent" && (enrollmentDetails.enrollmentStatus == "Present" || enrollmentDetails.enrollmentStatus == "Late"))
                            {
                                RecordTimeIn(IDNumberInt, student.Firstname, student.Lastname);
                            }
                            else //if previous log is absent
                            {
                                RecordTimeIn(IDNumberInt, student.Firstname, student.Lastname);

                            }
                            /*
                              
                            if (enrollmentDetails.enrollmentStatus == "Present" || enrollmentDetails.enrollmentStatus == "Late")
                                {
                                    txtTimeOut.Invoke(new Action(() => txtTimeOut.Text = ""));
                                }
                             */

                            //will try to make a condition about txtTimeOut.Invoke(new Action(() => txtTimeOut.Text = ""));
                            //apply condition
                            //Present, Late, not absent, 
                        }

                    }
                    else
                    {

                        // Populate the TextBoxes with student information
                        Photo.Image = null;
                        txtIDNumber.Invoke(new Action(() => txtIDNumber.Text = ""));
                        txtFirstName.Invoke(new Action(() => txtFirstName.Text = ""));
                        txtLastName.Invoke(new Action(() => txtLastName.Text = ""));
                        txtGender.Invoke(new Action(() => txtGender.Text = ""));
                        txtCourse.Invoke(new Action(() => txtCourse.Text = ""));
                        txtYear.Invoke(new Action(() => txtYear.Text = ""));
                        txtSchoolYear.Invoke(new Action(() => txtSchoolYear.Text = ""));
                        txtSemester.Invoke(new Action(() => txtSemester.Text = ""));
                        txtDescriptiveTitle.Invoke(new Action(() => txtDescriptiveTitle.Text = ""));
                        txtSubjectCode.Invoke(new Action(() => txtSubjectCode.Text = ""));
                        txtSchedule.Invoke(new Action(() => txtSchedule.Text = ""));
                        txtEnrollmentStatus.Invoke(new Action(() => txtEnrollmentStatus.Text = ""));

                        //Time
                        txtTimeIn.Invoke(new Action(() => txtTimeIn.Text = ""));
                        txtTimeOut.Invoke(new Action(() => txtTimeOut.Text = ""));

                        txtDescriptiveTitle.Invoke(new Action(() => txtDescriptiveTitle.Text = "No Student Account Found"));
                        labelNotification.Invoke(new Action(() => labelNotification.Text = ""));
                    }

                    finalFrame.SignalToStop();
                    await Task.Delay(1500); // 5000 milliseconds = 5 seconds
                    finalFrame.Start();

                }
                else
                {
                    MessageBox.Show("Invalid student ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to fetch enrollment details from the database
        //txtDescriptiveTitle.Invoke(new Action(() => txtDescriptiveTitle.Text = "No Student Account Found"));

        private Student GetStudentInfo(int IDNumber)
        {
            Student student = null;

            try
            {
                // Open the database connection
                connectionString.Open();

                // Query to fetch student information from StudentsAccounts table
                string query = "SELECT * FROM StudentsAccounts WHERE IDNumber = @IDNumber";
                using (SqlCommand command = new SqlCommand(query, connectionString))
                {
                    command.Parameters.AddWithValue("@IDNumber", IDNumber);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Create a new Student object and populate it with fetched data
                            student = new Student
                            {
                                Firstname = (string)reader["Firstname"],
                                Lastname = (string)reader["Lastname"],
                                Gender = (string)reader["Gender"],
                                Course = (string)reader["Course"],
                                Year = (string)reader["Year"],
                                SchoolYear = (string)reader["SchoolYear"],
                                Semester = (string)reader["Semester"],
                                Photo = reader["Photo"] as byte[]
                                // You can also fetch the photo here if needed
                            };
                            // Close the reader before executing the next command
                            reader.Close();
                            // Query to fetch TimeIn from the Attendance table
                            string timeInQuery = "SELECT TOP 1 TimeIn FROM Attendance WHERE IDNumber = @IDNumber ORDER BY AttendanceID DESC";
                            using (SqlCommand timeInCommand = new SqlCommand(timeInQuery, connectionString))
                            {
                                timeInCommand.Parameters.AddWithValue("@IDNumber", IDNumber);
                                object timeInResult = timeInCommand.ExecuteScalar();
                                if (timeInResult != null && timeInResult != DBNull.Value)
                                {
                                    TimeSpan timeIn = (TimeSpan)timeInResult;
                                    student.TimeIn = timeIn.ToString(); // Assuming TimeIn is of type TimeSpan
                                }
                            }

                            // Query to fetch TimeOut from the Attendance table
                            string timeOutQuery = "SELECT TOP 1 TimeOut FROM Attendance WHERE IDNumber = @IDNumber ORDER BY AttendanceID DESC";
                            using (SqlCommand timeOutCommand = new SqlCommand(timeOutQuery, connectionString))
                            {
                                timeOutCommand.Parameters.AddWithValue("@IDNumber", IDNumber);
                                object timeOutResult = timeOutCommand.ExecuteScalar();
                                if (timeOutResult != null && timeOutResult != DBNull.Value)
                                {
                                    TimeSpan timeOut = (TimeSpan)timeOutResult;
                                    student.TimeOut = timeOut.ToString(@"hh\:mm\:ss"); // Format TimeOut as needed
                                }
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching student information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the database connection
                connectionString.Close();
            }

            return student;
        }


        private bool IsStudentTimedIn(int IDNumber)
        {
            bool isTimedIn = false;

            try
            {
                // Open the database connection
                connectionString.Open();

                // Query to check if the student has timed in
                string query = "SELECT COUNT(*) FROM Attendance " +
                    "WHERE IDNumber = @IDNumber AND TimeOut IS NULL AND enrollmentStatus != 'Absent'";

                using (SqlCommand command = new SqlCommand(query, connectionString))
                {
                    command.Parameters.AddWithValue("@IDNumber", IDNumber);
                    int count = (int)command.ExecuteScalar();
                    isTimedIn = count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking student time in status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the database connection
                connectionString.Close();
            }

            return isTimedIn;
        }

        private Student VerifyStudentEnrollment(int IDNumber)
        {
            Student enrollmentDetails = null;

            try
            {
                // Open the database connection
                connectionString.Open();


                string query = "SELECT enrollmentStatus " +
                            "FROM Attendance "+
                            "WHERE IDNumber = @IDNumber "+
                            "ORDER BY AttendanceID DESC";

                using (SqlCommand command = new SqlCommand(query, connectionString))
                {
                    command.Parameters.AddWithValue("@IDNumber", IDNumber);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Read the enrollment status
                            enrollmentDetails = new Student
                            {
                                enrollmentStatus = (string)reader["enrollmentStatus"]
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error verifying student enrollment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the database connection
                connectionString.Close();
            }

            return enrollmentDetails;
        }

        private bool CanTimeOut(int IDNumber)
        {
            bool canTimeOut = false;

            try
            {
                // Open the database connection
                connectionString.Open();

                // Query to get the TimeIn and EndTime for the subject from attendance and subjectEnrollment tables
                string query = @"
            SELECT TOP 1 a.TimeIn, a.TimeOut, se.EndTime , a.Title, a.SubjectCode, a.Schedule, a.enrollmentStatus
            FROM Attendance a 
            JOIN subjectEnrollment se ON a.SubjectCode = se.SubjectCode 
            WHERE a.IDNumber = @IDNumber 
            AND a.TimeOut IS NULL 
            ORDER BY a.AttendanceID DESC"; // Ensure we get the latest record

                using (SqlCommand command = new SqlCommand(query, connectionString))
                {
                    command.Parameters.AddWithValue("@IDNumber", IDNumber);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DateTime timeIn = DateTime.Parse(reader["TimeIn"].ToString());
                            DateTime endTime = DateTime.Parse(reader["EndTime"].ToString());
                            DateTime currentDateTime = DateTime.Now;

                            // Calculate the time 15 minutes before the subject's end time
                            DateTime allowedTimeOutTime = endTime.AddMinutes(-15);

                            // Check if the current time is within the allowed timeout period
                            if (currentDateTime >= allowedTimeOutTime)
                            {
                                canTimeOut = true;
                            }
                            else
                            {
                                TimeSpan timeRemaining = allowedTimeOutTime - currentDateTime;
                                int remainingMinutes = (int)timeRemaining.TotalMinutes;

                                txtSubjectCode.Invoke(new Action(() => txtSubjectCode.Text = reader["SubjectCode"].ToString()));
                                txtSchedule.Invoke(new Action(() => txtSchedule.Text = reader["Schedule"].ToString()));
                                txtDescriptiveTitle.Invoke(new Action(() => txtDescriptiveTitle.Text = reader["Title"].ToString()));

                                string enrollmentStatus = reader["enrollmentStatus"].ToString();
                                txtEnrollmentStatus.Invoke(new Action(() =>
                                {
                                    txtEnrollmentStatus.Text = enrollmentStatus;
                                    if (enrollmentStatus == "Present")
                                    {
                                        txtEnrollmentStatus.FillColor = Color.Green;
                                        txtEnrollmentStatus.ForeColor = Color.White;
                                        txtEnrollmentStatus.Font = new Font(txtEnrollmentStatus.Font, FontStyle.Bold);
                                    }
                                    else if (enrollmentStatus == "Late")
                                    {
                                        txtEnrollmentStatus.FillColor = Color.Orange;
                                        txtEnrollmentStatus.ForeColor = Color.White;
                                        txtEnrollmentStatus.Font = new Font(txtEnrollmentStatus.Font, FontStyle.Bold);
                                    }
                                    else if (enrollmentStatus == "Not Enrolled")
                                    {
                                        txtEnrollmentStatus.FillColor = Color.Red;
                                        txtEnrollmentStatus.ForeColor = Color.White;
                                        txtEnrollmentStatus.Font = new Font(txtEnrollmentStatus.Font, FontStyle.Bold);
                                    }
                                    else
                                    {
                                        txtEnrollmentStatus.FillColor = Color.White;
                                        txtEnrollmentStatus.ForeColor = Color.Black;
                                        txtEnrollmentStatus.Font = new Font(txtEnrollmentStatus.Font, FontStyle.Bold);
                                    }
                                }));

                                // Format the DateTime value to display only the time part in "hh:mm tt" format
                                string formattedTimeIn = timeIn.ToString("hh:mm tt");

                                // Display the formatted time in txtTimeIn TextBox
                                txtTimeIn.Invoke(new Action(() => txtTimeIn.Text = formattedTimeIn));
                                txtTimeOut.Invoke(new Action(() => txtTimeOut.Text = ""));
                                // Update the notification label text
                                labelNotification.Invoke(new Action(() => labelNotification.Text = $"Cannot Time out yet. Please wait {remainingMinutes} minutes."));
                                // Set the label color to red
                                labelNotification.ForeColor = Color.Red;
                            }
                        }
                        else
                        {
                            labelNotification.Invoke(new Action(() => labelNotification.Text = "No valid time-in record found."));
                            labelNotification.ForeColor = Color.Red;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking time out eligibility: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the database connection
                connectionString.Close();
            }
            return canTimeOut;
        }

        private void btnCloseBox_Click(object sender, EventArgs e)
        {
            // Stop the camera
            if (finalFrame != null && finalFrame.IsRunning)
            {
                finalFrame.SignalToStop();
                finalFrame.WaitForStop();
            }

            // Stop the timer
            if (timer1 != null && timer1.Enabled)
            {
                timer1.Stop();
            }

            // Close the database connection if it's open
            if (connectionString != null && connectionString.State == ConnectionState.Open)
            {
                connectionString.Close();
            }

            // Optionally, perform any other cleanup operations here

            // Close the form
            this.Close();
        }

       
    }
}