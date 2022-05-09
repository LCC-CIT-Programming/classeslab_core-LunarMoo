using System;

namespace CustomerProductClasses
{
    public class Customer
    {
        public int id;
        public string firstName;
        public string lastName;
        public string email;
        public string phone;

        public Customer() { }

        public Customer(int customerId, string first, string last, string emailAddress, string phoneNum)
        {
            id = customerId;
            firstName = first;
            lastName = last ;
            email = emailAddress;
            phone = phoneNum;
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }
        public override string ToString()
        {
            return String.Format("Id: {0} First Name: {1} Last Name: {2} Email Address: {3} Phone Number: {4}", id, firstName, lastName, email, phone);
        }
    }
}
