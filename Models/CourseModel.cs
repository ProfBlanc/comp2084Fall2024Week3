using System.Text.RegularExpressions;

namespace WebApplication4.Models
{
    public class CourseModel
    {
        //fields: protected or private attributes
        //        when validation or restrictions are needs
        public int Id;  
        private string _courseCode;
        private string _courseName;


        //Properties: public wrappers for fields
        public string CourseCode {
            get { return _courseCode; }
            set {
                string defaultCourseCode = "comp2084";
                if (value.Length == 8) {
                
                    string first4Letters = value.Substring(0, 4);
                    string lastFourLetters = value.Substring(4);
                    var result1 = Regex.Match(first4Letters, "[a-z]", RegexOptions.IgnoreCase);
                    var result2 = Regex.Match(lastFourLetters, "[0-9]");
                    
                    _courseCode = result1.Success && result2.Success ? value : defaultCourseCode;
                    

                }
                else {
                    _courseCode = defaultCourseCode;
                }
                    }
        }

        public string CourseName {
            get => _courseName;
            set => _courseName = value.Length >= 4 ? value : "Course";
        }

        public CourseModel(int id, string courseName, string courseCode) {

            Id = id;
            CourseName = courseName;
            CourseCode = courseCode;
        }
    }

}
