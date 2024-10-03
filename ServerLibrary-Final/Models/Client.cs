using ServerLibrary.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Models
{
	internal class Client: IDisposable
	{
		public TcpClient socket;
		public User nguoiDung = null;
		public StreamReader reader;
		public StreamWriter writer;
		public Client(TcpClient socket)
		{
			this.socket = socket;
			reader = new StreamReader(socket.GetStream());
			writer = new StreamWriter(socket.GetStream());
			writer.AutoFlush = true;
		}

		public void Dispose()
		{
			writer.Close();
			reader.Close();
			socket.Close();
			GC.SuppressFinalize(this);
		}
	}
}
