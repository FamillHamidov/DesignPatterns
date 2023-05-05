﻿namespace DesignPattern.CQRS.CQRSPattern.Results
{
	public class GetProductByIdQueryResult
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public int Stock { get; set; }
		public decimal Price { get; set; }
		public string? Description { get; set; }
	}
}
