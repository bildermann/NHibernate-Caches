﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by AsyncGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Caching;
using NHibernate.Cache;
using NHibernate.Util;
using Environment = NHibernate.Cfg.Environment;

namespace NHibernate.Caches.SysCache2
{
	public partial class SysCacheRegion : ICache
	{

		#region ICache Members

		/// <inheritdoc />
		public Task ClearAsync(CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled<object>(cancellationToken);
			}
			try
			{
				Clear();
				return Task.CompletedTask;
			}
			catch (Exception ex)
			{
				return Task.FromException<object>(ex);
			}
		}

		/// <inheritdoc />
		public Task<object> GetAsync(object key, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled<object>(cancellationToken);
			}
			try
			{
				return Task.FromResult<object>(Get(key));
			}
			catch (Exception ex)
			{
				return Task.FromException<object>(ex);
			}
		}

		/// <inheritdoc />
		public Task LockAsync(object key, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled<object>(cancellationToken);
			}
			try
			{
				Lock(key);
				return Task.CompletedTask;
			}
			catch (Exception ex)
			{
				return Task.FromException<object>(ex);
			}
		}

		/// <inheritdoc />
		[SuppressMessage("Microsoft.Reliability", "CA2000:DisposeObjectsBeforeLosingScope")]
		public Task PutAsync(object key, object value, CancellationToken cancellationToken)
		{
			//validate the params
			if (key == null)
			{
				throw new ArgumentNullException(nameof(key));
			}

			if (value == null)
			{
				throw new ArgumentNullException(nameof(value));
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled<object>(cancellationToken);
			}
			try
			{
				Put(key, value);
				return Task.CompletedTask;
			}
			catch (Exception ex)
			{
				return Task.FromException<object>(ex);
			}
		}

		/// <inheritdoc />
		public Task RemoveAsync(object key, CancellationToken cancellationToken)
		{
			if (key == null)
			{
				throw new ArgumentNullException(nameof(key));
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled<object>(cancellationToken);
			}
			try
			{
				Remove(key);
				return Task.CompletedTask;
			}
			catch (Exception ex)
			{
				return Task.FromException<object>(ex);
			}
		}

		/// <inheritdoc />
		public Task UnlockAsync(object key, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled<object>(cancellationToken);
			}
			try
			{
				Unlock(key);
				return Task.CompletedTask;
			}
			catch (Exception ex)
			{
				return Task.FromException<object>(ex);
			}
		}

		#endregion
	}
}