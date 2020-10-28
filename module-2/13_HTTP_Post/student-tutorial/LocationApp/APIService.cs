using RestSharp;
using System;
using System.Collections.Generic;

namespace LocationApp
{
    public class APIService
    {
        const string API_URL = "http://localhost:3000/locations";
        readonly RestClient client = new RestClient();

        public List<Location> GetAllLocations()
        {
            RestRequest request = new RestRequest(API_URL);
            IRestResponse<List<Location>> response = client.Get<List<Location>>(request);
            return response.Data;
        }

        public Location GetDetailsForLocation(int locationId)
        {
            RestRequest requestOne = new RestRequest(API_URL + "/" + locationId);
            IRestResponse<Location> response = client.Get<Location>(requestOne);
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("An error occurred communicating with the server.");
                return null;
            }
            else if (!response.IsSuccessful)
            {
                Console.WriteLine("An error response was received from the server. The status code is " + (int)response.StatusCode);
                return null;
            }
            else
            {
                return response.Data;
            }
        }

        public Location AddLocation(Location newLocation)
        {
            //api code here
            RestRequest request = new RestRequest(API_URL);
            request.AddJsonBody(newLocation);
            IRestResponse<Location> response = client.Put<Location>(request);
            return response.Data;
        }

        public Location UpdateLocation(Location locationToUpdate)
        {
            //api code here
            RestRequest request = new RestRequest(API_URL + "/" + locationToUpdate.Id);
            request.AddJsonBody(locationToUpdate);
            IRestResponse<Location> response = client.Post<Location>(request);
            return response.Data;
        }

        public void DeleteLocation(int locationId)
        {
            //api code here
            RestRequest request = new RestRequest(API_URL + "/" + locationId);
            request.AddJsonBody(locationId);
            IRestResponse<Location> response = client.Delete<Location>(request);
            
        }
    }
}