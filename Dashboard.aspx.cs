using System;
using System.Collections.Generic;

namespace Review_Restaurant
{
    // Stores a single review left by one person
    public class Review
    {
        public string RestaurantName { get; set; }
        public string ReviewerName { get; set; }
        public int Rating { get; set; }  // 1 to 5
        public string ReviewText { get; set; }
        public DateTime Date { get; set; }
    }

    // Stores the summary info for one restaurant (used to show in the grid)
    public class RestaurantSummary
    {
        public string RestaurantName { get; set; }
        public string WeightedRating { get; set; }  // e.g. "4.20 / 5.00"
        public double WeightedRatingValue { get; set; }  // e.g. 4.2 (used for sorting/filtering)
        public List<Review> Reviews { get; set; }
    }

    public partial class Dashboard : System.Web.UI.Page
    {
        // Helper method to display star symbols (★ and ☆) based on rating
        // This method is called from the ASPX markup, so it must be public static
        public static string GetStars(int rating)
        {
            string stars = "";

            // Add filled stars (★)
            for (int i = 0; i < rating; i++)
            {
                stars = stars + "★";
            }

            // Add empty stars (☆)
            for (int i = rating; i < 5; i++)
            {
                stars = stars + "☆";
            }

            return stars;
        }

        // Returns a fixed list of all reviews
        // In a real app this would come from a database
        private List<Review> GetAllReviews()
        {
            DateTime now = DateTime.Now;

            List<Review> allReviews = new List<Review>();

            // --- Nasi Kandar Pelita ---
            Review r1 = new Review();
            r1.RestaurantName = "Nasi Kandar Pelita";
            r1.ReviewerName = "Ahmad";
            r1.Rating = 5;
            r1.Date = now.AddDays(-5);
            r1.ReviewText = "Hands down the best nasi kandar I have had in KL.";
            allReviews.Add(r1);

            Review r2 = new Review();
            r2.RestaurantName = "Nasi Kandar Pelita";
            r2.ReviewerName = "Priya";
            r2.Rating = 4;
            r2.Date = now.AddDays(-12);
            r2.ReviewText = "The curry is rich and very flavourful.";
            allReviews.Add(r2);

            Review r3 = new Review();
            r3.RestaurantName = "Nasi Kandar Pelita";
            r3.ReviewerName = "Jason";
            r3.Rating = 4;
            r3.Date = now.AddDays(-25);
            r3.ReviewText = "Really enjoyed the fish curry.";
            allReviews.Add(r3);

            Review r4 = new Review();
            r4.RestaurantName = "Nasi Kandar Pelita";
            r4.ReviewerName = "Siti";
            r4.Rating = 3;
            r4.Date = now.AddDays(-40);
            r4.ReviewText = "Food is decent but can get crowded.";
            allReviews.Add(r4);

            Review r5 = new Review();
            r5.RestaurantName = "Nasi Kandar Pelita";
            r5.ReviewerName = "Daniel";
            r5.Rating = 3;
            r5.Date = now.AddDays(-80);
            r5.ReviewText = "Average experience on my visit.";
            allReviews.Add(r5);

            Review r6 = new Review();
            r6.RestaurantName = "Nasi Kandar Pelita";
            r6.ReviewerName = "Sarah";
            r6.Rating = 2;
            r6.Date = now.AddDays(-120);
            r6.ReviewText = "Not as good as before.";
            allReviews.Add(r6);

            // --- Jalan Alor Hawker ---
            Review r7 = new Review();
            r7.RestaurantName = "Jalan Alor Hawker";
            r7.ReviewerName = "Mei Ling";
            r7.Rating = 5;
            r7.Date = now.AddDays(-3);
            r7.ReviewText = "The char kuey teow here is absolutely incredible.";
            allReviews.Add(r7);

            Review r8 = new Review();
            r8.RestaurantName = "Jalan Alor Hawker";
            r8.ReviewerName = "Rajan";
            r8.Rating = 5;
            r8.Date = now.AddDays(-18);
            r8.ReviewText = "Great variety of hawker food all in one street.";
            allReviews.Add(r8);

            Review r9 = new Review();
            r9.RestaurantName = "Jalan Alor Hawker";
            r9.ReviewerName = "Kevin";
            r9.Rating = 4;
            r9.Date = now.AddDays(-30);
            r9.ReviewText = "Grilled chicken wings and satay were excellent.";
            allReviews.Add(r9);

            Review r10 = new Review();
            r10.RestaurantName = "Jalan Alor Hawker";
            r10.ReviewerName = "Linda";
            r10.Rating = 3;
            r10.Date = now.AddDays(-55);
            r10.ReviewText = "Good food overall but gets packed on weekends.";
            allReviews.Add(r10);

            Review r11 = new Review();
            r11.RestaurantName = "Jalan Alor Hawker";
            r11.ReviewerName = "Susan";
            r11.Rating = 2;
            r11.Date = now.AddDays(-100);
            r11.ReviewText = "A bit overpriced for tourists.";
            allReviews.Add(r11);

            Review r12 = new Review();
            r12.RestaurantName = "Jalan Alor Hawker";
            r12.ReviewerName = "Ahmed";
            r12.Rating = 4;
            r12.Date = now.AddDays(-140);
            r12.ReviewText = "Good atmosphere but crowded.";
            allReviews.Add(r12);

            // --- Restoran Yut Kee ---
            Review r13 = new Review();
            r13.RestaurantName = "Restoran Yut Kee";
            r13.ReviewerName = "David";
            r13.Rating = 5;
            r13.Date = now.AddDays(-7);
            r13.ReviewText = "A true KL heritage gem.";
            allReviews.Add(r13);

            Review r14 = new Review();
            r14.RestaurantName = "Restoran Yut Kee";
            r14.ReviewerName = "Nurul";
            r14.Rating = 4;
            r14.Date = now.AddDays(-20);
            r14.ReviewText = "Very nostalgic feel and great coffee.";
            allReviews.Add(r14);

            Review r15 = new Review();
            r15.RestaurantName = "Restoran Yut Kee";
            r15.ReviewerName = "Thomas";
            r15.Rating = 4;
            r15.Date = now.AddDays(-35);
            r15.ReviewText = "Came here on a weekday morning and it was great.";
            allReviews.Add(r15);

            Review r16 = new Review();
            r16.RestaurantName = "Restoran Yut Kee";
            r16.ReviewerName = "Kevin";
            r16.Rating = 3;
            r16.Date = now.AddDays(-60);
            r16.ReviewText = "Good food but gets very packed.";
            allReviews.Add(r16);

            Review r17 = new Review();
            r17.RestaurantName = "Restoran Yut Kee";
            r17.ReviewerName = "Rachel";
            r17.Rating = 3;
            r17.Date = now.AddDays(-90);
            r17.ReviewText = "Classic spot but seating is limited.";
            allReviews.Add(r17);

            Review r18 = new Review();
            r18.RestaurantName = "Restoran Yut Kee";
            r18.ReviewerName = "Jason";
            r18.Rating = 4;
            r18.Date = now.AddDays(-130);
            r18.ReviewText = "The pork chop is delicious.";
            allReviews.Add(r18);

            // --- Madam Kwan's ---
            Review r19 = new Review();
            r19.RestaurantName = "Madam Kwan's";
            r19.ReviewerName = "Farah";
            r19.Rating = 4;
            r19.Date = now.AddDays(-10);
            r19.ReviewText = "The nasi lemak here is top notch.";
            allReviews.Add(r19);

            Review r20 = new Review();
            r20.RestaurantName = "Madam Kwan's";
            r20.ReviewerName = "James";
            r20.Rating = 4;
            r20.Date = now.AddDays(-22);
            r20.ReviewText = "Solid Malaysian food in a comfortable setting.";
            allReviews.Add(r20);

            Review r21 = new Review();
            r21.RestaurantName = "Madam Kwan's";
            r21.ReviewerName = "Thomas";
            r21.Rating = 3;
            r21.Date = now.AddDays(-45);
            r21.ReviewText = "Food is good but a bit pricey.";
            allReviews.Add(r21);

            Review r22 = new Review();
            r22.RestaurantName = "Madam Kwan's";
            r22.ReviewerName = "Anna";
            r22.Rating = 3;
            r22.Date = now.AddDays(-75);
            r22.ReviewText = "Decent Malaysian cuisine.";
            allReviews.Add(r22);

            Review r23 = new Review();
            r23.RestaurantName = "Madam Kwan's";
            r23.ReviewerName = "Lily";
            r23.Rating = 2;
            r23.Date = now.AddDays(-110);
            r23.ReviewText = "Had better Malaysian food elsewhere.";
            allReviews.Add(r23);

            // --- Lot 10 Hutong ---
            Review r24 = new Review();
            r24.RestaurantName = "Lot 10 Hutong";
            r24.ReviewerName = "Haziq";
            r24.Rating = 5;
            r24.Date = now.AddDays(-2);
            r24.ReviewText = "So many famous heritage stalls under one roof.";
            allReviews.Add(r24);

            Review r25 = new Review();
            r25.RestaurantName = "Lot 10 Hutong";
            r25.ReviewerName = "Michelle";
            r25.Rating = 4;
            r25.Date = now.AddDays(-15);
            r25.ReviewText = "Tried the Hokkien mee and wonton noodles.";
            allReviews.Add(r25);

            Review r26 = new Review();
            r26.RestaurantName = "Lot 10 Hutong";
            r26.ReviewerName = "Anna";
            r26.Rating = 3;
            r26.Date = now.AddDays(-48);
            r26.ReviewText = "Good food but hard to find a seat.";
            allReviews.Add(r26);

            Review r27 = new Review();
            r27.RestaurantName = "Lot 10 Hutong";
            r27.ReviewerName = "Ben";
            r27.Rating = 3;
            r27.Date = now.AddDays(-85);
            r27.ReviewText = "A convenient option if you are at Lot 10.";
            allReviews.Add(r27);

            Review r28 = new Review();
            r28.RestaurantName = "Lot 10 Hutong";
            r28.ReviewerName = "Raj";
            r28.Rating = 2;
            r28.Date = now.AddDays(-115);
            r28.ReviewText = "Quality has dropped compared to before.";
            allReviews.Add(r28);

            Review r29 = new Review();
            r29.RestaurantName = "Lot 10 Hutong";
            r29.ReviewerName = "Siti";
            r29.Rating = 4;
            r29.Date = now.AddDays(-145);
            r29.ReviewText = "Good variety of food options.";
            allReviews.Add(r29);

            return allReviews;
        }

        // Calculates a weighted average rating for a restaurant.
        // Recent reviews (within 3 months) count DOUBLE to reflect current quality better.
        private double CalculateWeightedRating(List<Review> reviews)
        {
            DateTime threeMonthsAgo = DateTime.Now.AddMonths(-3);

            double totalScore = 0;
            double totalWeight = 0;

            for (int i = 0; i < reviews.Count; i++)
            {
                Review review = reviews[i];

                // Recent review gets weight 2, older review gets weight 1
                double weight;
                if (review.Date >= threeMonthsAgo)
                {
                    weight = 2.0;
                }
                else
                {
                    weight = 1.0;
                }

                totalScore = totalScore + (review.Rating * weight);
                totalWeight = totalWeight + weight;
            }

            // Avoid dividing by zero if there are no reviews
            if (totalWeight == 0)
            {
                return 0;
            }

            double averageRating = totalScore / totalWeight;
            return averageRating;
        }

        // Builds a summary list of restaurants, filtered by a minimum rating
        private List<RestaurantSummary> GetSummaries(double minimumRating)
        {
            List<Review> allReviews = GetAllReviews();

            // Step 1 — Collect all unique restaurant names
            List<string> restaurantNames = new List<string>();

            for (int i = 0; i < allReviews.Count; i++)
            {
                string name = allReviews[i].RestaurantName;

                // Only add the name if it is not already in the list
                if (!restaurantNames.Contains(name))
                {
                    restaurantNames.Add(name);
                }
            }

            // Step 2 — Build a summary for each restaurant
            List<RestaurantSummary> summaries = new List<RestaurantSummary>();

            for (int i = 0; i < restaurantNames.Count; i++)
            {
                string currentName = restaurantNames[i];

                // Step 3 — Collect all reviews that belong to this restaurant
                List<Review> restaurantReviews = new List<Review>();

                for (int j = 0; j < allReviews.Count; j++)
                {
                    if (allReviews[j].RestaurantName == currentName)
                    {
                        restaurantReviews.Add(allReviews[j]);
                    }
                }

                // Step 4 — Sort reviews from newest to oldest (bubble sort)
                for (int x = 0; x < restaurantReviews.Count - 1; x++)
                {
                    for (int y = 0; y < restaurantReviews.Count - 1 - x; y++)
                    {
                        if (restaurantReviews[y].Date < restaurantReviews[y + 1].Date)
                        {
                            // Swap the two reviews
                            Review temp = restaurantReviews[y];
                            restaurantReviews[y] = restaurantReviews[y + 1];
                            restaurantReviews[y + 1] = temp;
                        }
                    }
                }

                // Step 5 — Calculate the weighted rating
                double weightedValue = CalculateWeightedRating(restaurantReviews);

                // Step 6 — Build the summary object and add it to the list
                RestaurantSummary summary = new RestaurantSummary();
                summary.RestaurantName = currentName;
                summary.WeightedRatingValue = weightedValue;
                summary.WeightedRating = weightedValue.ToString("0.00") + " / 5.00";
                summary.Reviews = restaurantReviews;

                summaries.Add(summary);
            }

            // Step 7 — Filter out restaurants below the minimum rating
            List<RestaurantSummary> filtered = new List<RestaurantSummary>();

            for (int i = 0; i < summaries.Count; i++)
            {
                if (summaries[i].WeightedRatingValue >= minimumRating)
                {
                    filtered.Add(summaries[i]);
                }
            }

            // Step 8 — Sort filtered list from highest rating to lowest (bubble sort)
            for (int x = 0; x < filtered.Count - 1; x++)
            {
                for (int y = 0; y < filtered.Count - 1 - x; y++)
                {
                    if (filtered[y].WeightedRatingValue < filtered[y + 1].WeightedRatingValue)
                    {
                        // Swap the two summaries
                        RestaurantSummary temp = filtered[y];
                        filtered[y] = filtered[y + 1];
                        filtered[y + 1] = temp;
                    }
                }
            }

            return filtered;
        }

        // Runs once when the page first loads (not on button clicks)
        protected void Page_Load(object sender, EventArgs e)
        {
            // IsPostBack is false only on the very first load
            // On button clicks or dropdown changes, IsPostBack becomes true
            if (!IsPostBack)
            {
                BindGrid(0);  // 0 means no minimum — show all restaurants
            }
        }

        // Fills the grid with restaurant data based on the minimum rating
        private void BindGrid(double minimumRating)
        {
            List<RestaurantSummary> summaries = GetSummaries(minimumRating);

            gvRestaurants.DataSource = summaries;
            gvRestaurants.DataBind();

            // Hide the reviews panel whenever the grid is refreshed
            pnlReviews.Visible = false;
        }

        // Fires when the user picks a different value from the rating dropdown
        protected void ddlMinRating_SelectedIndexChanged(object sender, EventArgs e)
        {
            double minimumRating = double.Parse(ddlMinRating.SelectedValue);
            BindGrid(minimumRating);
        }

        // Fires when the user clicks on a restaurant name
        protected void gvRestaurants_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            // Only handle the "ViewReviews" command, ignore everything else
            if (e.CommandName != "ViewReviews")
            {
                return;
            }

            string selectedName = e.CommandArgument.ToString();
            double minimumRating = double.Parse(ddlMinRating.SelectedValue);

            // Get the full summary list
            List<RestaurantSummary> summaries = GetSummaries(minimumRating);

            // Find the restaurant the user clicked on
            RestaurantSummary selectedSummary = null;

            for (int i = 0; i < summaries.Count; i++)
            {
                if (summaries[i].RestaurantName == selectedName)
                {
                    selectedSummary = summaries[i];
                    break;  // Found it, no need to keep looping
                }
            }

            // Show the reviews panel with that restaurant's reviews
            lblRestaurantName.Text = selectedSummary.RestaurantName;

            // Bind the reviews to the repeater
            rptReviews.DataSource = selectedSummary.Reviews;
            rptReviews.DataBind();

            // Show the panel
            pnlReviews.Visible = true;
        }
    }
}