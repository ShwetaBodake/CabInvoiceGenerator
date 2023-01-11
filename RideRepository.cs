using System;
namespace CabInvoiceGenerator
{
	public class RideRepository
	{
		Dictionary<string, List<Ride>> userRides = null;

		public RideRepository()
		{
			this.userRides = new Dictionary<string, List<Ride>>();
		}


		public void AddRide(string userID, Ride[] rides)
		{
			bool rideList = this.userRides.ContainsKey(userID);
			try
			{
				if(! rideList)
				{
					List<Ride> List = new List<Ride>();
					List.AddRange(rides);
					this.userRides.Add(userID, List);

				}
			}catch(CabInvoiceException)
			{
				throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_USER_ID, "Rides are null");
			}
		}

		public Ride[] GetRides(string userId)
		{
			try
			{
				return this.userRides[userId].ToArray();
			}catch(CabInvoiceException)
			{
				throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_USER_ID, "Invalid userID");
			}
		}
	}
}

