using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Youtuber
{
	private string nome;

	private string canal;

	private List<Video> videos;

	public List<string> teste;

	public string Nome{ get; set; }

	public string Canal{ get; set; }

	public List<Video> Videos
	{
		get
		{
			if (videos == null)
				videos = new List<Video>();

			return videos;
		}
		set
		{
			if (videos == null)
				videos = new List<Video>();

			videos = value;
		}
	}

	public void imprimirDados()
	{
		Console.WriteLine("Nome: " + Nome);
		Console.WriteLine("Canal: " + Canal);
		if(Videos != null)
		{
			foreach(Video item in this.videos)
			{
				item.imprimirDados();
			}
		}
	}

}

