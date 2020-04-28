using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Program
    {
		public class Agenda
		{
			public bool AddContact(Contact contact)
			{
				Contacts.Add(contact);
				return true;
			}


			public void ViewList()
			{

				foreach (Contact contact in Contacts)
				{
					Console.WriteLine(contact.Nume);
					Console.WriteLine("Data: " + contact.Data);
					Console.WriteLine("Activitate: " + contact.Activitate);
					Console.WriteLine("");
				}
			}

			public List<Contact> Contacts = new List<Contact>();

		}

		public class Contact
		{
			public string Nume;
			public string Data;
			public string Activitate;
		}
		static void Main(string[] args)
        {
			string option = "";
			Agenda agenda = new Agenda();

			while (option != "3")
			{
				Console.WriteLine("1.- Adauga un contact in agenda");
				Console.WriteLine("2.- Vezi lista de contact");
				Console.WriteLine("3.- iesire din contact");
				option = Console.ReadLine();

				switch (option)
				{
					case "1":
						AddContact(agenda);
						break;

					case "2":
						ViewList(agenda);
						break;
					default:
						option = "3";
						break;
				}

			}


		}
	
		public static void AddContact(Agenda agenda)
		{
			Console.WriteLine("Nume");
			string nume = Console.ReadLine();

			Console.WriteLine("Data");
			string data = Console.ReadLine();

			Console.WriteLine("Activitatea");
			string activitate = Console.ReadLine();

			Contact contact = new Contact();
			contact.Nume = nume;
			contact.Data = data;
			contact.Activitate = activitate;

			agenda.AddContact(contact);

		}
		public static void ViewList(Agenda agenda)
        {
            agenda.ViewList();

        }
    }
}
