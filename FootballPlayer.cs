namespace Assignment1CAndUnitTests
{
    public class FootballPlayer
    {

        #region Properties
        public int ID { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public int ShirtNumber { get; set; }
        #endregion

        #region Methods
        public void Validate()
        {
            ValidateID();
            ValidateName();
            ValidateAge();
            ValidateShirtNumber();
        }

        /// <summary>
        /// Method that validates the value of ID.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">An exception thrown if ID is negative.</exception>
        public void ValidateID()
        {
            if (ID <= 0) throw new ArgumentOutOfRangeException("ID Must be a positive integer.");
        }

        /// <summary>
        /// Method that validates the value of Name.
        /// </summary>
        /// <exception cref="ArgumentNullException">An exception thrown if Name is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">An exception thrown if Name is less than 2 characters long.</exception>
        public void ValidateName()
        {
            if (string.IsNullOrEmpty(Name)) throw new ArgumentNullException("Name cannot be an empty or null value.");
            if (Name.Length < 2) throw new ArgumentOutOfRangeException("Name must be of length greater than or equal to 2.");
        }

        /// <summary>
        /// Method that validates the value of Age.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">An exception throw if Age is less than 1.</exception>
        public void ValidateAge()
        {
            if (Age <= 0) throw new ArgumentOutOfRangeException("Age must be of length greater than or equal to 1.");
        }

        /// <summary>
        /// Method that validates the value of ShirtNumber.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">An exception thrown if ShirtNumber is less than 1, or greater than 99.</exception>
        public void ValidateShirtNumber()
        {
            if (ShirtNumber < 1 || ShirtNumber > 99) throw new ArgumentOutOfRangeException("ShirtNumber must be greather than or equal to 1, and less than or equal to 99.");
        }
        #endregion

    }
}