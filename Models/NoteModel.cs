namespace MantenanceProjetASPNET6.Models
{
   
    public class NoteModel
    {
        public string Cne { get; set; }
        public double Note { get; set; }
    }
    public class NotesRequestModel
    {
        public List<NoteModel> Notes { get; set; }
        public int Niveau { get; set; }
    }

}
