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

        [MessageBodyMember]
        public int DeptId;
    }

    [MessageContract]
    public class EmployeeResponse
    {
        [MessageHeader]
        public string CompanyName;

        [MessageBodyMember]
        public List<Employee> Emp;

        [MessageBodyMember]
        public Department Dept;
    }

    [DataContract]
    [KnownType(typeof(Admin))]
    [KnownType(typeof(Manager))]
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

    [DataContract]
    public class Admin : Employee
    {
        private string a_Value;

        [DataMember]
        public string Value
        {
            get { return a_Value; }
            set { a_Value = value; }
        }
    }

    [DataContract]
    public class Manager : Employee
    {
        private string m_Value;

        [DataMember]
        public string Value
        {
            get { return m_Value; }
            set { m_Value = value; }
        }
    }

    [DataContract]
    public class Department
    {
        private int m_DeptId;
        private string m_DeptName;

        [DataMember]
        public string Name
        {
            get { return m_DeptName; }
            set { m_DeptName = value; }
        }

        [DataMember]
        public int Id
        {
            get { return m_DeptId; }
            set { m_DeptId = value; }
        }
    }
}