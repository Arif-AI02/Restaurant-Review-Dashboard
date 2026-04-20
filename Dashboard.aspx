<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="Review_Restaurant.Dashboard" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Restaurant Review Dashboard</title>
    <style>
        body { font-family: Arial, sans-serif; margin: 30px; background: #f5f5f5; }
        h1 { color: #333; }
        .filter-bar { margin-bottom: 15px; }
        
        table { width: 100%; border-collapse: collapse; background: white; }
        th { background: #5c2d91; color: white; padding: 12px 15px; text-align: left; }
        td { padding: 12px 15px; border-bottom: 1px solid #ddd; vertical-align: middle; }
        tr:hover td { background: #f0eaff; }
        
        th:nth-child(1), td:nth-child(1) { width: 60%; }
        th:nth-child(2), td:nth-child(2) { width: 40%; }
        
        .restaurant-link {
            color: #5c2d91;
            text-decoration: none;
            font-weight: bold;
            cursor: pointer;
        }
        .restaurant-link:hover {
            text-decoration: underline;
            color: #7a3fbf;
        }
        
        .panel {
            margin-top: 25px;
            background: white;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 4px;
        }
        .panel h2 { color: #5c2d91; margin-top: 0; }
        .review-card { border-bottom: 1px solid #eee; padding: 12px 0; }
        .review-card:last-child { border-bottom: none; }
        .stars { color: #f5a623; }
        .meta { color: #888; font-size: 12px; }
        .no-reviews {
            padding: 20px;
            text-align: center;
            color: #888;
        }
    </style>
</head>
<body>
<form id="form1" runat="server">
    <h1>Restaurant Review Dashboard — KL</h1>
    
    <div class="filter-bar">
        <label><b>Filter by Minimum Rating: </b></label>
        <asp:DropDownList ID="ddlMinRating" runat="server"
            AutoPostBack="true"
            OnSelectedIndexChanged="ddlMinRating_SelectedIndexChanged">
            <asp:ListItem Text="Show All" Value="0" />
            <asp:ListItem Text="1 star and above" Value="1" />
            <asp:ListItem Text="2 stars and above" Value="2" />
            <asp:ListItem Text="3 stars and above" Value="3" />
            <asp:ListItem Text="4 stars and above" Value="4" />
        </asp:DropDownList>
    </div>
    
    <asp:GridView ID="gvRestaurants" runat="server"
        AutoGenerateColumns="false"
        DataKeyNames="RestaurantName"
        OnRowCommand="gvRestaurants_RowCommand"
        ShowHeaderWhenEmpty="true">
        <Columns>
            <asp:TemplateField HeaderText="Restaurant">
                <ItemTemplate>
                    <asp:LinkButton ID="lnkRestaurant" runat="server"
                        CommandName="ViewReviews"
                        CommandArgument='<%# Eval("RestaurantName") %>'
                        CssClass="restaurant-link"
                        Text='<%# Eval("RestaurantName") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="WeightedRating" HeaderText="Weighted Avg Rating" />
        </Columns>
        <EmptyDataTemplate>
            <div style="padding: 20px; text-align: center;">
                No restaurants found matching the selected criteria.
            </div>
        </EmptyDataTemplate>
    </asp:GridView>
    
    <asp:Panel ID="pnlReviews" runat="server" Visible="false" CssClass="panel">
        <h2>Reviews for: <asp:Label ID="lblRestaurantName" runat="server" /></h2>
        
        <asp:Repeater ID="rptReviews" runat="server">
            <ItemTemplate>
                <div class="review-card">
                    <b><%# Eval("ReviewerName") %></b>
                    <span class="meta"> — <%# Eval("Date", "{0:dd MMM yyyy}") %></span>
                    <div class="stars">
                        <%# GetStars((int)Eval("Rating")) %>
                        (<%# Eval("Rating") %>/5)
                    </div>
                    <div><%# Eval("ReviewText") %></div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
        
        <!-- Show message when no reviews exist -->
        <div id="divNoReviews" runat="server" class="no-reviews" visible="false">
            No reviews available for this restaurant.
        </div>
    </asp:Panel>
</form>
</body>
</html>