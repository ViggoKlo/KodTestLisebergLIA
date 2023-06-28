using DataAccess.Models;
using DataAccess.Repositories;
using DataAccess.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Kodtest_Liseberg_LIA.Server
{
    public static class Endpoints
    {
        static GuestRepository guestRepository = new GuestRepository();

        public static WebApplication MapGuestEndpoints(this WebApplication app)
        {
            app.MapPost("/GuestAdd", AddGuest);
            app.MapGet("/GuestsAll", GetAllGuests);
            app.MapPut("/GuestUpdate", UpdateGuest);
            app.MapDelete("/GuestDelete/{id}", DeleteGuest);
            app.MapGet("/GuestById/{id}", GetGuestById);
            return app;
        }

        private static IResult AddGuest(Guest guest)
        {
            guestRepository.Add(guest);

            return Results.Ok();
        }

        private static IResult GetAllGuests() 
        {
            return Results.Ok(guestRepository.GetAll());
        }

        private static IResult UpdateGuest(Guest guest)
        {
            guestRepository.Update(guest);

            return Results.Ok();
        }

        private static IResult DeleteGuest(Guid id) 
        {
            guestRepository.Delete(id);

            return Results.Ok();
        }

        private static IResult GetGuestById(Guid id)
        {
            return Results.Ok(guestRepository.GetById(id));
        }
    }
}
