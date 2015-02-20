﻿using System.IO;
using NUnit.Framework;

namespace SikuliSharp.Tests.Unit
{
	[TestFixture]
	public class AsyncTwoWayStreamsHandlerFactoryTests
	{
		[Test]
		public void CanCreateAnInstance()
		{
			var sr = new StreamReader(new MemoryStream());
			var sw = new StreamWriter(new MemoryStream());

			Assert.That(new AsyncTwoWayStreamsHandlerFactory().Create(sr, sw), Is.TypeOf<AsyncTwoWayStreamsHandler>());
		}
	}
}