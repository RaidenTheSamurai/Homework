using System;
using System.Collections.Generic;

// Модель «Замітка»
public class Note
{
    public string Title { get; set; }
    public string Text { get; set; }
    public DateTime CreatedDate { get; set; }
    public List<string> Tags { get; set; }

    public Note(string title, string text, List<string> tags)
    {
        Title = title;
        Text = text;
        CreatedDate = DateTime.Now;
        Tags = tags;
    }
}

// Модель «Контакт»
public class Contact
{
    public string Name { get; set; }
    public string MobilePhone { get; set; }
    public string AlternateMobilePhone { get; set; }
    public string Email { get; set; }
    public string Description { get; set; }

    public Contact(string name, string mobilePhone, string alternateMobilePhone, string email, string description)
    {
        Name = name;
        MobilePhone = mobilePhone;
        AlternateMobilePhone = alternateMobilePhone;
        Email = email;
        Description = description;
    }
}

// Контролер для роботи з Замітками
public class NoteController
{
    private List<Note> notes = new List<Note>();

    public void AddNote(Note note)
    {
        notes.Add(note);
    }

    public List<Note> GetAllNotes()
    {
        return notes;
    }
}

// Контролер для роботи з Контактами
public class ContactController
{
    private List<Contact> contacts = new List<Contact>();

    public void AddContact(Contact contact)
    {
        contacts.Add(contact);
    }

    public List<Contact> GetAllContacts()
    {
        return contacts;
    }
}

// Вид для виведення інформації на екран
public class ConsoleView
{
    public void DisplayNotes(List<Note> notes)
    {
        foreach (var note in notes)
        {
            Console.WriteLine("Title: " + note.Title);
            Console.WriteLine("Created Date: " + note.CreatedDate);
            Console.WriteLine("Text: " + note.Text);
            Console.WriteLine("Tags: " + string.Join(", ", note.Tags));
            Console.WriteLine();
        }
    }

    public void DisplayContacts(List<Contact> contacts)
    {
        foreach (var contact in contacts)
        {
            Console.WriteLine("Name: " + contact.Name);
            Console.WriteLine("Mobile Phone: " + contact.MobilePhone);
            Console.WriteLine("Alternate Mobile Phone: " + contact.AlternateMobilePhone);
            Console.WriteLine("Email: " + contact.Email);
            Console.WriteLine("Description: " + contact.Description);
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створюємо контролери та види
        NoteController noteController = new NoteController();
        ContactController contactController = new ContactController();
        ConsoleView consoleView = new ConsoleView();

        // Додаємо замітки та контакти
        noteController.AddNote(new Note("Note 1", "Note text 1", new List<string> { "tag1", "tag2" }));
        noteController.AddNote(new Note("Note 2", "Note text 2", new List<string> { "tag3" }));
        contactController.AddContact(new Contact("Contact 1", "123-456-789", "987-654-321", "email1@example.com", "Description 1"));
        contactController.AddContact(new Contact("Contact 2", "555-555-555", "", "email2@example.com", "Description 2"));


        // Виводимо інформацію
        Console.WriteLine("Notes:");
        consoleView.DisplayNotes(noteController.GetAllNotes());

        Console.WriteLine("Contacts:");
        consoleView.DisplayContacts(contactController.GetAllContacts());

    }
}
