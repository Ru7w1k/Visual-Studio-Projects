using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WCFDemo
{
    [MessageContract]
    public class EmployeeRequest
    {
        [MessageHeader]
        public string Key;

        [MessageBodyMember]
        public int Id;
    }

    [MessageContract]
    public class EmployeeResponse
    {
        [MessageHeader]
        public string CompanyName;

        [MessageBodyMember]
        public Employee Emp;
    }

    [DataContract]
    public class Employee
    {
        private int m_Id;
        private string m_Name;
        private int m_Age;
        private double m_Salary;

        [DataMember]
        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }

        [DataMember]
        public int Id
        {
            get { return m_Id; }
            set { m_Id = value; }
        }

        [DataMember]
        public int Age
        {
            get { return m_Age; }
            set { m_Age = value; }
        }

        [DataMember]
        public double Salary
        {
            get { return m_Salary; }
            set { m_Salary = value; }
        }
    }
}