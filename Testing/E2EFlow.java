public class E2EFlow {

  @Test
	public void completeTicketBookingProcessWithRegistration() {

  createRegistration();
  loginUser();
  selectCity();
  searchMovieWithName();
  selectMovie();
  selectNoOfTickets();
  completePayment();
  validateTicketBookingIsSuccessful();

	}

}