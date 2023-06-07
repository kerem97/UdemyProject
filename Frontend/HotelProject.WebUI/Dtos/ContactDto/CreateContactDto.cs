namespace HotelProject.WebUI.Dtos.ContactDto
{
    public class CreateContactDto
    {
       
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public DateTime MessageDate { get; set; }
    }
}
