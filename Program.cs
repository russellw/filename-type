using MimeMapping;

internal class Program {
	static void Main(string[] args) {
		var filename = args[0];
		Console.WriteLine(MimeUtility.GetMimeMapping(filename));
	}
}
