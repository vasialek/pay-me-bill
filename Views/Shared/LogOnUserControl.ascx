<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%
    if (Request.IsAuthenticated) {
%>
        Welcome <b><%= Html.Encode(Page.User.Identity.Name) %></b>!
        [ <a href="<%= Url.Action("logout", "user") %>">Logout</a> ]
<%
    }
    else {
%> 
        [ <a href="<%= Url.Action("login", "user") %>">Login</a> ]
<%
    }
%>
