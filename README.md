### What I Built
A restaurant review dashboard that displays restaurants in Kuala Lumpur with weighted average ratings. Recent reviews (within the last 3 months) count double to reflect current quality more accurately.

### Features
1. View all restaurants sorted by weighted average rating (highest first)
2. Filter restaurants by minimum rating threshold (1-5 stars)
3. Click any restaurant to see all its individual reviews
4. Recency-weighted ratings - Reviews from last 3 months count 2x

### Tech Stack
1. ASP.NET Web Forms (.NET Framework 4.0)
2. C# for backend logic
3. HTML/CSS for styling

### How to Run
Prerequisites
1. Visual Studio 2019 or 2022 (any edition)
2. .NET Framework 4.0 or higher

### RESTAURANT REVIEW DASHBOARD - HOW TO RUN (STEP BY STEP)
STEP 1: * Clone the repository
* Open Command Prompt or Git Bash and run:
* git clone https://github.com/Arif-AI02/Restaurant-Review-Dashboard.git

STEP 2: * Open the project in Visual Studio
* Launch Visual Studio (2019 or 2022)
* Click "Open a project or solution" on the start page
* OR go to File → Open → Project/Solution
* Navigate to the folder where you cloned the repository
* Select the file named "Review_Restaurant.cln"
* Click "Open"

STEP 3: Build the project
* In Visual Studio, go to the top menu
* Click Build → Build Solution
* OR press Ctrl + Shift + B
* Wait for the message "Build succeeded" at the bottom

STEP 4: Run the application
* Press F5 on your keyboard
* OR click the green "Play" button that says "IIS Express"

STEP 5: Use the dashboard
* Your browser will open automatically. Now you can:
* VIEW ALL RESTAURANTS:
* The main page shows all restaurants
* They are sorted by weighted average rating (highest first)
* Each row shows restaurant name and their rating
* FILTER BY MINIMUM RATING:
* Look for the dropdown at the top
* Select "3 stars and above" to see only highly-rated restaurants
* The list updates automatically
* VIEW INDIVIDUAL REVIEWS:
* Click on any restaurant name (it's a purple link)
* A panel will appear below showing all reviews for that restaurant
* Each review shows:
* Reviewer name
* Date of review
* Rating (1/5)
* Full review text
* CLEAR THE REVIEWS PANEL:
* Use the filter dropdown again
* The reviews panel will hide automatically

STEP 6: Stop the application. 
* Close the browser window. 
* OR in Visual Studio, click Debug → Stop Debugging. 
* OR press Shift + F5.

### What I'd Improve with More Time
1. Persistent storage - Replace in-memory data with a real database (SQL Server or SQLite)
2. Add/Edit/Delete reviews - Allow users to submit new reviews through a form
3. User authentication - Let reviewers log in and manage their own reviews
4. Adding numbers of restaurants/reviews with page navigation
5. Charts and analytics - Add visualizations for rating distributions
6. Add pictures of each restaurant to make it more appealing
   
### One Thing I Got Stuck On (And How I Solved It)
The Problem:
* I initially had a compilation error CS0103: The name 'GetStars' does not exist in the current context because I was calling a the method from the ASPX markup that wasn't accessible.
.
How I solved it: using deepseek

* After reading the error message carefully, I realized the GetStars method was defined inside the RestaurantSummary class. Since the method was tied to the class, the ASPX page couldn't find it in the current context. After that i defined it inside the public partial class Dashboard : System.Web.UI.Page. Now its accessible.


### Tools and Resources Used
1. Claude - Helped me to write the code and get some idea how can i build the system.
2. GitHub - Submitting the project
3. Visual Studio 2022 - Developing the project
4. DeepSeek - for error handling
