﻿using NUnit.Framework;
using Shuttle.ESB.Tests;

namespace Shuttle.ESB.RabbitMQ.Tests
{
	public class RabbitMQDistributorTest : DistributorFixture
	{
		[Test]
		[TestCase(false)]
		[TestCase(true)]
		public void Should_be_able_to_distribute_messages(bool isTransactionalEndpoint)
		{
			TestDistributor(@"rabbitmq://shuttle:shuttle!@localhost/{0}", isTransactionalEndpoint);
		}
	}
}