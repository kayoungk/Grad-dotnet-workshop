using System;

namespace WorkshopLibrary
{
    public class EmployeeNote
    {
        public int EmployeeId { get; set; }
        public DateTime Created { get; set; }
        public NoteTypes NoteType { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return $"{EmployeeId}: {Created} - {NoteType}: {Text}";
        }
    }
}