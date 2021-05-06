using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Resume.My.Persistence.Data
{
	public class ResumeLike
	{
		[Key]
		public Guid Id { get; set; }
		public string SystemName { get; set; }
		public string IPAddress { get; set; }
		public string SystemOS { get; set; }
		public bool IsLiked { get; set; }
		public long Counter { get; set; }
		public DateTime Date { get; set; }
		public override string ToString() => Counter.ToString();

	}
}
