using System;
using System.Text;
using System.IO;

namespace TextEditorBL
{
	public interface IFileManager
	{
		string GetContent(string filePath);
		string GetContent(string filePath, Encoding encoding);
		void SaveContent(string content, string filePath);
		void SaveContent(string content, string filePath, Encoding encoding);
		int GetSymbolCount(string count);
		bool isExist(string filePath);
	}
	public class FileManager: IFileManager
	{
		private readonly Encoding _defaultEncoding = Encoding.GetEncoding(1251);

		public bool isExist(string filePath)
		{
			return File.Exists(filePath);
		}

		public string GetContent(string filePath)
		{
			return GetContent(filePath, _defaultEncoding);
		}

		public string GetContent(string filePath, Encoding encoding)
		{
			string content = File.ReadAllText(filePath, encoding);
			return content;
		}

		public void SaveContent(string content, string filePath)
		{
			SaveContent(content, filePath, _defaultEncoding);
		}

		public void SaveContent(string content, string filePath, Encoding encoding)
		{
			File.WriteAllText(filePath, content, encoding);
		}

		public int GetSymbolCount(string count)
		{
			return count.Length;
		}

	}
}
