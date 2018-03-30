using Project_Sce.DAL;
using Project_Sce.CodeLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_12_A_B;

namespace Project_12_A_B.CodeLayer
{
    public class Handler
    {
        private static int dbConnAttempts = 3;

        public Handler()
        {

        }

        public bool ConnectToDB()
        {
            while (dbConnAttempts != 0)
            {
                DataBase db = DataBase.Instance;
                if (!db.OpenConnection())
                {
                    // Cannot connect to Data Base, will try in next attempt
                    dbConnAttempts--;
                }
                else
                {
                    //Connected to Data Base
                    break;
                }
            }

            if (dbConnAttempts == 0)
            {
                return false;
            }

            return true;
        }

        public bool DisconnectFromDB()
        {
            DataBase db = DataBase.Instance;
            return db.CloseConnection();
        }

        public T Get<T>(T t)
        {
            if (t is Lecturer)
            {
                Lecturer lecturer = t as Lecturer;
                t = (T)(object)GetLecturer(lecturer);
                return t;
            }
            else if (t is Classroom)
            {
                Classroom classroom = t as Classroom;
                t = (T)(object)GetClassroom(classroom);
                return t;
            }
            else if (t is Cls_Login)
            {
                Cls_Login login = t as Cls_Login;
                t = (T)(object)GetCls_Login(login);
                return t;
            }
            return t;
        }

        public List<T> GetList<T>(T t)
        {
            if (t is Course)
            {
                Course course = t as Course;
                List<T> courses = (List<T>)(object)GetCourses(course);
                return courses;
            }
            else if (t is Lecturer)
            {
                Lecturer lecturer = t as Lecturer;
                List<T> lecturers = (List<T>)(object)GetLecturers(lecturer);
                return lecturers;
            }
            else if (t is Project_Sce.CodeLayer.Constraint)
            {
                Project_Sce.CodeLayer.Constraint constraint = t as Project_Sce.CodeLayer.Constraint;
                List<T> constraints = (List<T>)(object)GetConstraints(constraint);
                return constraints;
            }
            else if (t is Classroom)
            {
                Classroom classRoom = t as Classroom;
                List<T> classRooms = (List<T>)(object)GetClassrooms(classRoom);
                return classRooms;
            }
            else if (t is Lesson)
            {
                Lesson lesson = t as Lesson;
                List<T> lessons = (List<T>)(object)GetLessons(lesson);
                return lessons;
            }
            return null;
        }

        public DataTable GetDataTable<T>(T t)
        {
            if (t is Course)
            {
                Course course = t as Course;
                DataTable courses = ConvertToDataTable<T>((List<T>)(object)GetCourses(course));
                return courses;
            }
            else if (t is Project_Sce.CodeLayer.Student)
            {
                //Project_Sce.CodeLayer.Student student = t as Student;
                //return student.get_All_Students();

                Project_Sce.CodeLayer.Student student = t as Project_Sce.CodeLayer.Student;
                DataTable students = ConvertToDataTable<T>((List<T>)(object)GetStudents(student));
                return students;
            }
            else if (t is Lecturer)
            {
                //Project_Sce.CodeLayer.Student student = t as Student;
                //return student.get_All_Students();

                Lecturer lecturer = t as Lecturer;
                DataTable lecturers = ConvertToDataTable<T>((List<T>)(object)GetLecturers(lecturer));
                return lecturers;
            }
            else if (t is Project_Sce.CodeLayer.Constraint)
            {
                //Project_Sce.CodeLayer.Student student = t as Student;
                //return student.get_All_Students();

                Project_Sce.CodeLayer.Constraint constraint = t as Project_Sce.CodeLayer.Constraint;
                DataTable constraints = ConvertToDataTable<T>((List<T>)(object)GetConstraints(constraint));
                return constraints;
            }
            else if (t is Classroom)
            {
                //Project_Sce.CodeLayer.Student student = t as Student;
                //return student.get_All_Students();

                Classroom classRoom = t as Classroom;
                DataTable classRooms = ConvertToDataTable<T>((List<T>)(object)GetClassrooms(classRoom));
                return classRooms;
            }
            else if (t is Lesson)
            {
                Lesson lesson = t as Lesson;
                DataTable lessons = ConvertToDataTable<T>((List<T>)(object)GetLessons(lesson));
                return lessons;
            }
            return null;
        }

        public bool Delete<T>(T t)
        {
            if (t is Lecturer)
            {
                Lecturer lecturer = t as Lecturer;
                bool result = DeleteLecturer(lecturer);
                return result;
            }
            else if (t is Project_Sce.CodeLayer.Student)
            {
                Project_Sce.CodeLayer.Student student = t as Project_Sce.CodeLayer.Student;
                bool result = DeleteStudent(student);
                return result;
            }
            return false;
        }

        public bool Add<T>(T t)
        {
            if (t is Lecturer)
            {
                Lecturer lecturer = t as Lecturer;
                bool result = AddLecturer(lecturer);
                return result;
            }
            else if (t is Project_Sce.CodeLayer.Constraint)
            {
                Project_Sce.CodeLayer.Constraint c = t as Project_Sce.CodeLayer.Constraint;
                bool result = AddConstraint(c);
                return result;
            }
            return false;
        }

        public bool Update<T>(T t)
        {
            if (t is Lecturer)
            {
                Lecturer lecturer = t as Lecturer;
                bool result = UpdateLecturer(lecturer);
                return result;
            }
            else if (t is Course)
            {
                Course course = t as Course;
                bool result = UpdateCourse(course);
                return result;
            }
            else if (t is Project_Sce.CodeLayer.Student)
            {
                Project_Sce.CodeLayer.Student student = t as Project_Sce.CodeLayer.Student;
                bool result = UpdateStudent(student);
                return result;
            }
            return false;
        }

        public Lecturer GetLecturer(Lecturer toGetLecturer)
        {
            int lid = -1, hoursPerWeek = -1;
            string id = null, firstName = null, lastName = null, address = null, email = null, tel = null, department = null, degree = null, login = null, password = null;
            DateTime birthDay = default(DateTime);
            bool flag = false;

            DataBase db = DataBase.Instance;

            SqlCommand cmd = new SqlCommand
            (
                "SELECT * from Lecturer WHERE (id='" + toGetLecturer.ID + "')", db.Con // at this time get lecturer only by id, in the future by all keys
            );

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    //int example1 = reader.GetInt32(0); string example2 = reader.GetString(1); // another way to get values sergei note
                    lid = (int)reader["lid"];
                    id = reader["id"].ToString().Trim();
                    firstName = reader["first_name"].ToString().Trim();
                    lastName = reader["last_name"].ToString().Trim();
                    address = reader["address"].ToString().Trim();
                    email = reader["email"].ToString().Trim();
                    tel = reader["tel"].ToString().Trim();
                    DateTime.TryParse(reader["birth_day"].ToString().Trim(), out birthDay);
                    //birthDay = DateTime.Parse(reader["birth_day"].ToString().Trim());
                    department = reader["department"].ToString().Trim();
                    degree = reader["degree"].ToString().Trim();
                    hoursPerWeek = Convert.ToInt32(reader["hours_per_week"]);
                    flag = true;
                }
            }

            if (toGetLecturer.Login != null)
            {
                cmd = new SqlCommand
                (
                    "SELECT * from Login WHERE (Name='" + toGetLecturer.Login + "')", db.Con // get login only by login Name
                );
            }
            else
            if (toGetLecturer.ID != null)
            {
                cmd = new SqlCommand
                (
                    "SELECT * from Login WHERE (Id='" + toGetLecturer.ID + "')", db.Con // get login only by login Name
                );
            }

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    login = reader["Name"].ToString().Trim();
                    password = reader["Password"].ToString().Trim();
                }
            }

            if (flag)
            {
                Lecturer lecturer = new Lecturer(id, firstName, lastName, address, email, tel, birthDay, login, password, department, degree, hoursPerWeek);
                return lecturer;
            }

            return null;
        }

        public Classroom GetClassroom(Classroom toGeClassroom)
        {
            DataBase db = DataBase.Instance;

            SqlCommand cmd = new SqlCommand
            (
                "SELECT * from Class WHERE (name='" + toGeClassroom.Name + "')", db.Con
            );

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    int seatsNum = (int)reader["seats_num"];
                    bool projector = (bool)reader["projector"];
                    bool computer = (bool)reader["computer"];
                    return new Classroom(toGeClassroom.Name, seatsNum, projector, computer);
                }
            }
            return null;
        }

        public Cls_Login GetCls_Login(Cls_Login toGeLogin)
        {
            DataBase db = DataBase.Instance;

            string where = toGeLogin.ID != null ? " WHERE (Id = '" + toGeLogin.ID + "')" : toGeLogin.Email != null ? " WHERE (Email = '" + toGeLogin.Email + "')" : "";

            SqlCommand cmd = new SqlCommand
            (
                "SELECT * from Login" + where, db.Con
            );

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string id = reader["Id"].ToString().Trim();
                    string email = reader["Email"].ToString().Trim();
                    string password = reader["Password"].ToString().Trim();
                    //...
                    return new Cls_Login(id, email, password);
                }
            }
            return null;
        }


        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }

        private int GetSqlNullableInt(object reader)
        {
            if (reader != DBNull.Value)
            {
                return (int)reader;
            }
            else
            {
                return 0;
            }
        }

        private bool GetSqlNullableBool(object reader)
        {
            if (reader != DBNull.Value)
            {
                return (bool)reader;
            }
            else
            {
                return false;
            }
        }

        public List<Course> GetCourses(Course course)
        {
            List<Course> courses = new List<Course>();

            DataBase db = DataBase.Instance;

            SqlCommand cmd = new SqlCommand
            (
                "SELECT * from Courses", db.Con // at this time get all courses, in the future by all keys // WHERE (key='" + course.key + "')
            );

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    //int example1 = reader.GetInt32(0); string example2 = reader.GetString(1); // another way to get values sergei note
                    string cid = reader["CourseID"].ToString().Trim();
                    //int cid = (int)reader["CourseID"];
                    string name = reader["Name"].ToString().Trim();
                    int hoursPerWeek = this.GetSqlNullableInt(reader["HoursPerWeek"]);
                    float points = (float)(double)reader["Points"];
                    string category = reader["Category"].ToString().Trim();
                    bool lab = GetSqlNullableBool(reader["Lab"]);
                    bool practition = GetSqlNullableBool(reader["Practition"]);
                    string semester = reader["Semester"].ToString().Trim();
                    bool registerOption = reader["RegisterOption"].ToString().Trim() == "True" || reader["RegisterOption"].ToString().Trim() == "1" ? true : false;
                    //bool registerOption = GetSqlNullableBool(reader["RegisterOption"]);
                    int year = this.GetSqlNullableInt(reader["Year"]);
                    //Convert.ToInt32(var);
                    courses.Add(new Course(cid, name, hoursPerWeek, points, category, practition, lab, semester, year, registerOption));
                }
            }

            return courses;
        }

        public List<Project_Sce.CodeLayer.Student> GetStudents(Project_Sce.CodeLayer.Student student)
        {
            List<Project_Sce.CodeLayer.Student> students = new List<Project_Sce.CodeLayer.Student>();

            DataBase db = DataBase.Instance;

            SqlCommand cmd = new SqlCommand
            (
                "SELECT * from Student", db.Con // at this time get all students, in the future by all keys // WHERE (key='" + course.key + "')
            );

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    //int example1 = reader.GetInt32(0); string example2 = reader.GetString(1); // another way to get values sergei note
                    int id = Convert.ToInt32(reader["StudID"]);
                    string name = reader["Name"].ToString().Trim();
                    int year = (int)reader["Year"];
                    float average = (float)(double)reader["Average"];
                    string address = reader["Address"].ToString().Trim();
                    string email = reader["Email"].ToString().Trim();
                    string semester = reader["Semester"].ToString().Trim();
                    bool cyber = reader["Cyber"] == DBNull.Value ? false : Convert.ToBoolean(reader["Cyber"]);

                    //Convert.ToInt32(var);
                    students.Add(new Project_Sce.CodeLayer.Student(id, name, year, average, address, email, semester, cyber));
                }
            }

            return students;
        }

        public List<Lecturer> GetLecturers(Lecturer lecturer)
        {
            List<Lecturer> lecturers = new List<Lecturer>();

            DataBase db = DataBase.Instance;

            SqlCommand cmd = new SqlCommand
            (
                "SELECT * from Lecturer", db.Con // at this time get all lecturers, in the future by all keys // WHERE (key='" + course.key + "')
            );

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    //int example1 = reader.GetInt32(0); string example2 = reader.GetString(1); // another way to get values sergei note
                    int lid = (int)reader["lid"];
                    string id = reader["id"].ToString().Trim();
                    string firstName = reader["first_name"].ToString().Trim();
                    string lastName = reader["last_name"].ToString().Trim();
                    string address = reader["address"].ToString().Trim();
                    string email = reader["email"].ToString().Trim();
                    string tel = reader["tel"].ToString().Trim();
                    DateTime birthDay = default(DateTime);
                    DateTime.TryParse(reader["birth_day"].ToString().Trim(), out birthDay);
                    string department = reader["department"].ToString().Trim();
                    string degree = reader["degree"].ToString().Trim();
                    int hoursPerWeek = Convert.ToInt32(reader["hours_per_week"]);

                    //Convert.ToInt32(var);
                    lecturers.Add(new Lecturer(id, firstName, lastName, address, email, tel, birthDay, null, null, department, degree, hoursPerWeek));
                }
            }

            return lecturers;
        }

        public List<Project_Sce.CodeLayer.Constraint> GetConstraints(Project_Sce.CodeLayer.Constraint constraint)
        {
            List<Project_Sce.CodeLayer.Constraint> constraints = new List<Project_Sce.CodeLayer.Constraint>();

            DataBase db = DataBase.Instance;

            SqlCommand cmd = new SqlCommand
            (
                "SELECT * from Constraints", db.Con // at this time get all constraints
            );

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    //int example1 = reader.GetInt32(0); string example2 = reader.GetString(1); // another way to get values sergei note
                    int cid = (int)reader["conId"];
                    string lid = reader["LecturerID"].ToString().Trim();
                    string day = reader["Day"].ToString().Trim();
                    int fromHour = (int)reader["StrtTime"];
                    int toHour = (int)reader["EndTime"];

                    //Convert.ToInt32(var);
                    constraints.Add(new Project_Sce.CodeLayer.Constraint(cid, lid, day, fromHour, toHour));
                }
            }

            return constraints;
        }

        public List<Classroom> GetClassrooms(Classroom classRoom)
        {
            List<Classroom> classRooms = new List<Classroom>();

            DataBase db = DataBase.Instance;

            SqlCommand cmd = new SqlCommand
            (
                "SELECT * from Class", db.Con // at this time get all constraints
            );

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    //int example1 = reader.GetInt32(0); string example2 = reader.GetString(1); // another way to get values sergei note
                    int cid = (int)reader["cid"];
                    string name = reader["name"].ToString().Trim();
                    int seatsNum = (int)reader["seats_num"];
                    bool projector = (bool)reader["projector"];
                    bool computer = (bool)reader["computer"];

                    //Convert.ToInt32(var);
                    classRooms.Add(new Classroom(name, seatsNum, projector, computer));
                }
            }

            return classRooms;
        }

        public List<Lesson> GetLessons(Lesson lesson)
        {
            List<Lesson> lessons = new List<Lesson>();
            DataBase db = DataBase.Instance;

            SqlCommand cmd = new SqlCommand
            (
                "SELECT * from Lesson" + (lesson.ClassroomName != null ? " WHERE ClassRoom='" + lesson.ClassroomName + "'" : ""), db.Con
            );

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string cls = reader["ClassRoom"].ToString().Trim();
                    string d = reader["Day"].ToString().Trim();
                    int strt = (int)reader["StrtTime"];
                    int end = (int)reader["EndTime"];

                    //Convert.ToInt32(var);
                    lessons.Add(new Lesson(null, cls, null, null, d, strt, end));
                }
            }

            return lessons;
        }

        public bool DeleteLecturer(Lecturer toDeleteLecturer)
        {
            DataBase db = DataBase.Instance;
            SqlCommand cmd = new SqlCommand
            (
                "DELETE from Lecturer WHERE (id='" + toDeleteLecturer.ID + "')", db.Con
            );

            int result = cmd.ExecuteNonQuery();

            cmd = new SqlCommand
            (
                "UPDATE Lesson SET LecturerID=NULL WHERE LecturerID='" + toDeleteLecturer.ID + "';", db.Con
            );

            result += cmd.ExecuteNonQuery();

            cmd = new SqlCommand
            (
                "DELETE from Login WHERE (Id='" + toDeleteLecturer.ID + "')", db.Con
            );

            result += cmd.ExecuteNonQuery();

            return result == 3 ? true : false;
        }

        public bool DeleteStudent(Project_Sce.CodeLayer.Student toDeleteStudent)
        {
            DataBase db = DataBase.Instance;
            SqlCommand cmd = new SqlCommand
            (
                "DELETE from Student WHERE (StudID='" + toDeleteStudent.ID + "')", db.Con
            );

            int result = cmd.ExecuteNonQuery();

            return result == 0 ? false : true;
        }

        public bool AddLecturer(Lecturer toAddLecturer)
        {
            DataBase db = DataBase.Instance;

            SqlCommand cmd = new SqlCommand
            (
                "INSERT INTO Lecturer(id,first_name,last_name,degree,address,email,tel,birth_day,department,hours_per_week,login,password) OUTPUT INSERTED.lid VALUES(@id,@first_name,@last_name,@degree,@address,@email,@tel,@birth_day,@department,@hours_per_week,@login,@password);", db.Con
            );

            cmd.Parameters.Add("@id", SqlDbType.NChar, toAddLecturer.ID.Length).Value = toAddLecturer.ID;
            cmd.Parameters.Add("@first_name", SqlDbType.NChar, toAddLecturer.FirstName.Length).Value = toAddLecturer.FirstName;
            cmd.Parameters.Add("@last_name", SqlDbType.NChar, toAddLecturer.LastName.Length).Value = toAddLecturer.LastName;
            cmd.Parameters.Add("@degree", SqlDbType.NChar, 50).Value = toAddLecturer.Degree;
            cmd.Parameters.Add("@address", SqlDbType.NChar, 50).Value = toAddLecturer.Address;
            cmd.Parameters.Add("@email", SqlDbType.NChar, 50).Value = toAddLecturer.Email;
            cmd.Parameters.Add("@tel", SqlDbType.NChar, 20).Value = toAddLecturer.Tel;
            cmd.Parameters.Add("@birth_day", SqlDbType.Date).Value = toAddLecturer.BirthDay;
            cmd.Parameters.Add("@department", SqlDbType.NChar, 10).Value = toAddLecturer.Department;
            cmd.Parameters.Add("@hours_per_week", SqlDbType.Float).Value = toAddLecturer.HoursPerWeek;
            cmd.Parameters.Add("@login", SqlDbType.NChar, 50).Value = "";
            cmd.Parameters.Add("@password", SqlDbType.NChar, 20).Value = "";

            Int32 lid = (Int32)cmd.ExecuteScalar();

            SqlCommand cmd1 = new SqlCommand
            (
                "INSERT INTO Login(Id,Name,Password,Permission,isLogged,Email,Semester,Address) VALUES(@Id,@Name,@Password,@Permission,@isLogged,@Email,@Semester,@Address)", db.Con
            );

            cmd1.Parameters.Add("@Id", SqlDbType.NChar, 10).Value = toAddLecturer.ID.ToString();
            cmd1.Parameters.Add("@Name", SqlDbType.NChar, 50).Value = toAddLecturer.Login;
            cmd1.Parameters.Add("@Password", SqlDbType.NChar, 10).Value = toAddLecturer.Password;
            cmd1.Parameters.Add("@Permission", SqlDbType.NChar, 10).Value = "5";
            cmd1.Parameters.Add("@isLogged", SqlDbType.NChar, 10).Value = "0";
            cmd1.Parameters.Add("@Email", SqlDbType.NChar, 50).Value = toAddLecturer.Email;
            cmd1.Parameters.Add("@Semester", SqlDbType.NChar, 10).Value = "";
            cmd1.Parameters.Add("@Address", SqlDbType.NChar, 50).Value = toAddLecturer.Address;

            int result = cmd1.ExecuteNonQuery() + lid;

            return result == 0 ? false : true;
        }

        public bool AddConstraint(Project_Sce.CodeLayer.Constraint toAddConstraint)
        {
            DataBase db = DataBase.Instance;

            SqlCommand cmd = new SqlCommand
            (
                "INSERT INTO Constraints (LecturerID,Day,StrtTime,EndTime) OUTPUT INSERTED.conId VALUES(@lid,@day,@from_hour,@to_hour);", db.Con
            );

            cmd.Parameters.Add("@lid", SqlDbType.NChar, 20).Value = toAddConstraint.LID;
            cmd.Parameters.Add("@day", SqlDbType.NChar, 10).Value = toAddConstraint.Day;
            cmd.Parameters.Add("@from_hour", SqlDbType.Int).Value = toAddConstraint.FromHour;
            cmd.Parameters.Add("@to_hour", SqlDbType.Int).Value = toAddConstraint.ToHour;

            Int32 cid = (Int32)cmd.ExecuteScalar();

            return cid == 0 ? false : true;
        }


        public bool UpdateLecturer(Lecturer lecturer)
        {
            DataBase db = DataBase.Instance;

            SqlCommand cmd = new SqlCommand
            (
                "UPDATE Lecturer SET id=@id, first_name=@first_name, last_name=@last_name, degree=@degree, address=@address, email=@email, tel=@tel, birth_day=@birth_day, department=@department, hours_per_week=@hours_per_week, login=@login, password=@password WHERE id='" + lecturer.ID + "';", db.Con
            );

            cmd.Parameters.Add("@id", SqlDbType.NChar, 10).Value = lecturer.ID;
            cmd.Parameters.Add("@first_name", SqlDbType.NChar, 50).Value = lecturer.FirstName;
            cmd.Parameters.Add("@last_name", SqlDbType.NChar, 50).Value = lecturer.LastName;
            cmd.Parameters.Add("@degree", SqlDbType.NChar, 50).Value = lecturer.Degree;
            cmd.Parameters.Add("@address", SqlDbType.NChar, 50).Value = lecturer.Address;
            cmd.Parameters.Add("@email", SqlDbType.NChar, 50).Value = lecturer.Email;
            cmd.Parameters.Add("@tel", SqlDbType.NChar, 20).Value = lecturer.Tel;
            cmd.Parameters.Add("@birth_day", SqlDbType.Date).Value = lecturer.BirthDay;
            cmd.Parameters.Add("@department", SqlDbType.NChar, 10).Value = lecturer.Department;
            cmd.Parameters.Add("@hours_per_week", SqlDbType.Float).Value = lecturer.HoursPerWeek;
            cmd.Parameters.Add("@login", SqlDbType.NChar, 50).Value = "";
            cmd.Parameters.Add("@password", SqlDbType.NChar, 20).Value = "";

            int lid = cmd.ExecuteNonQuery();

            SqlCommand cmd1 = new SqlCommand
            (
                "UPDATE Login SET Id=@Id ,Name=@Name ,Password=@Password ,Permission=@Permission ,isLogged=@isLogged ,Email=@Email ,Semester=@Semester ,Address=@Address WHERE id='" + lecturer.ID + "';", db.Con
            );

            cmd1.Parameters.Add("@Id", SqlDbType.NChar, 10).Value = lecturer.ID.ToString();
            cmd1.Parameters.Add("@Name", SqlDbType.NChar, 50).Value = lecturer.Login;
            cmd1.Parameters.Add("@Password", SqlDbType.NChar, 10).Value = lecturer.Password;
            cmd1.Parameters.Add("@Permission", SqlDbType.NChar, 10).Value = "5";
            cmd1.Parameters.Add("@isLogged", SqlDbType.NChar, 10).Value = "0";
            cmd1.Parameters.Add("@Email", SqlDbType.NChar, 50).Value = lecturer.Email;
            cmd1.Parameters.Add("@Semester", SqlDbType.NChar, 10).Value = "";
            cmd1.Parameters.Add("@Address", SqlDbType.NChar, 50).Value = lecturer.Address;

            int result = cmd1.ExecuteNonQuery() + lid;

            return result == 0 ? false : true;
        }

        public bool UpdateCourse(Course course)
        {
            DataBase db = DataBase.Instance;

            SqlCommand cmd = new SqlCommand
            (
                "UPDATE Courses SET name=@name, HoursPerWeek=@HoursPerWeek, Points=@Points, Category=@Category, Lab=@Lab, Practition=@Practition, Semester=@Semester, RegisterOption=@RegisterOption, Year=@Year WHERE CourseID='" + course.ID + "';", db.Con
            );

            cmd.Parameters.Add("@name", SqlDbType.NChar, 50).Value = course.Name;
            cmd.Parameters.Add("@HoursPerWeek", SqlDbType.Int).Value = course.HoursPerWk;
            cmd.Parameters.Add("@Points", SqlDbType.Float).Value = course.Point;
            cmd.Parameters.Add("@Category", SqlDbType.NVarChar, 20).Value = course.Category;
            cmd.Parameters.Add("@Lab", SqlDbType.Bit).Value = course.Lab;
            cmd.Parameters.Add("@Practition", SqlDbType.Bit).Value = course.Practition;
            cmd.Parameters.Add("@Semester", SqlDbType.NChar, 10).Value = course.Semester;
            cmd.Parameters.Add("@RegisterOption", SqlDbType.NChar, 10).Value = course.RegisterOption.ToString();
            cmd.Parameters.Add("@Year", SqlDbType.Int).Value = course.Year;

            int result = cmd.ExecuteNonQuery();

            return result == 0 ? false : true;
        }

        public bool UpdateStudent(Project_Sce.CodeLayer.Student student)
        {
            DataBase db = DataBase.Instance;

            SqlCommand cmd = new SqlCommand
            (
                "UPDATE Student SET Name=@Name, Year=@Year, Average=@Average, Address=@Address, Email=@Email, Semester=@Semester, Cyber=@Cyber WHERE StudID='" + student.ID + "';", db.Con
            );

            cmd.Parameters.Add("@Name", SqlDbType.NChar, 50).Value = student.Name;
            cmd.Parameters.Add("@Year", SqlDbType.Int).Value = student.Year;
            cmd.Parameters.Add("@Average", SqlDbType.Float).Value = student.Average;
            cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = student.Address;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = student.Email;
            cmd.Parameters.Add("@Semester", SqlDbType.NVarChar).Value = student.Semester;
            cmd.Parameters.Add("@Cyber", SqlDbType.Bit).Value = student.Cyber;

            int result = cmd.ExecuteNonQuery();

            return result == 0 ? false : true;
        }
    }

}
