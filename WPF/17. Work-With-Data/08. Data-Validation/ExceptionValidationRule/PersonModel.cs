using System;

namespace ExceptionValidationRule
{
    public class PersonModel : IDataErrorInfo
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Position { get; set; }

        public string this[string columnName]
        {
            get
            {
                string error = String.Empty;

                switch (columnName)
                {
                    case "Age":
                        if (Age < 0 || Age > 100)
                        {
                            error = "Age must be between 0 and 100.";
                        }

                        break;
                    case "Name":
                        // Error handling for Name
                        break;
                    case "Position":
                        // Error handling for Position
                        break;
                }

                return error;
            }
        }

        public string Error
        {
            get { throw new NotImplementedException(); }
        }
    }
}
