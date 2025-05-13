namespace FashionMVCProject.Models;

public class FeaturedProducts : BaseModel
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImgUrl { get; set; }
    public int Price { get; set; }
}
