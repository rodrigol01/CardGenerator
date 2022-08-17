﻿using CardGenerator.Domain.Interfaces;

namespace CardGenerator.Domain.Entities;

public class DebitCardEntity : IGenericCardEntity
{
    public int PersonId { get; set; }
    public string PersonName { get; set; }
    public long CardNumber { get; set; }
    public DateTime ExpireDate { get; set; }
    public int CodeSecurity { get; set; }
    public string FunctionCard { get; set; }
    public string HierarchyOfCardEnum { get; set; }
    public bool IsActive { get; set; }
}