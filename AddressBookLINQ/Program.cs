using System.Data;

namespace AddressBookLINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\tWelcome to Address Book Program using LINQ\n\n");

            DataTable addressBookTable = new DataTable();

            DataColumn column;
            DataRow row;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "firstName";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "lastName";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "address";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "city";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "state";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "zip";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Double");
            column.ColumnName = "phoneNumber";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "eMail";
            addressBookTable.Columns.Add(column);

            DataColumn[] PrimaryKeyColumns = new DataColumn[2];
            PrimaryKeyColumns[0] = addressBookTable.Columns["firstName"];
            PrimaryKeyColumns[1] = addressBookTable.Columns["phoneNumber"];
            addressBookTable.PrimaryKey = PrimaryKeyColumns;


            addressBookTable.Rows.Add("Lokesh", "Sonawane", "Warje", "Pune", "Maharashtra", 411058, 9876543210, "lokesh.sonawane@gmail.com");
            addressBookTable.Rows.Add("Mohak", "Mangal", "Hennur", "Bengaluru", "Karnataka", 410253, 9513064780, "mohak.mangal@gmail.com");
            addressBookTable.Rows.Add("John", "Connor", "Andheri", "Mumbai", "Maharashtra", 400256, 7532016498, "john.connor@gmail.com");
            addressBookTable.Rows.Add("Lok", "Son", "Kothrud", "Pune", "Maharashtra", 411040, 7745612309, "lok.son@gmail.com");
            addressBookTable.Rows.Add("Ahan", "Mishra", "Begampura", "Delhi", "Dehli", 465123, 8420165978, "ahan.mishra@gmail.com");
            addressBookTable.Rows.Add("Vicky", "Kaushal", "Andheri", "Mumbai", "Maharashtra", 751320, 9632201579, "vicky.kaushal@gmail.com");


            AddressBookManagement addressBookManagement = new AddressBookManagement();

            // UC4 update data
            addressBookTable = addressBookManagement.UpdatedContactDetails(addressBookTable);

            addressBookManagement.DisplayAllData(addressBookTable);
        }
    }
}