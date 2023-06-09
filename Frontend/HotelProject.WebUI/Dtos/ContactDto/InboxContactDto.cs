namespace HotelProject.WebUI.Dtos.ContactDto
{
    public class InboxContactDto
    {
        public int ContactID { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public DateTime MessageDate { get; set; }
    }
}
