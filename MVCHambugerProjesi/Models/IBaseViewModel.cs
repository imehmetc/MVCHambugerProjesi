namespace MVCHambugerProjesi.Models
{
    public interface IBaseViewModel
    {
        int Id { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime? ModifiedDate { get; set; }
        DateTime? DeletedDate { get; set; }
        bool IsDeleted { get; set; }
    }
}
