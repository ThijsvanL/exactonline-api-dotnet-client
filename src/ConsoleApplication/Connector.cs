﻿using ExactOnline.Client.OAuth;
using System;

namespace ConsoleApplication
{
	public class Connector
	{
		private readonly string _clientId;
		private readonly string _clientSecret;
		private readonly Uri _callbackUrl;

		private readonly static UserAuthorization Authorization = new UserAuthorization();

		public string EndPoint
		{
			get
			{
				return "https://start.exactonline.nl";
			}
		}

		public Connector(string clientId, string clientSecret, Uri callbackUrl)
		{
			_clientId = clientId;
			_clientSecret = clientSecret;
			_callbackUrl = callbackUrl;
		}

		public string GetAccessToken()
		{
			UserAuthorizations.Authorize(Authorization, EndPoint, _clientId, _clientSecret, _callbackUrl);

			return Authorization.AccessToken;
		}

	}
}
