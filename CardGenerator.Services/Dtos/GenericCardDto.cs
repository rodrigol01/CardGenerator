namespace CardGenerator.Services;

public class GenericCardDto
{
    public Guid PersonId { get; set; }
    public string PersonName { get; set; }
    public long CardNumber { get; set; }
    public DateTime ExpireDate { get; set; }
    public int CodeSecurity { get; set; }
    public FunctionCardEnum FunctionCard { get; set; }
    public HierarchyOfCard HierarchyOfCard { get; set; }
    public bool IsActive { get; set; }
}