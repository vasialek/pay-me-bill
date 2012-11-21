<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Main.Master" Inherits="System.Web.Mvc.ViewPage<PayMe.Models.Bill>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Show
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Bill <%= Html.Encode(Model.Name) %></h2>
    
    <div class="DebtorsList">
        <% foreach( var debtor in Model.Debtors )
           { %>
            <div style="display: table-row;">
                <div class="w100" style="display: table-cell;"><%= Html.Encode(debtor) %></div>
                <div class="w50" style="display: table-cell;"><%= Model.getTotalForDebtor(debtor).ToString("0.02") %></div>
            </div>
        <% } %>
    </div>
    
    <div><h4>Debts</h4></div>
    
    <% if( Model.Items != null
           ){ %>
        <div class="DebtorsList">
        <% foreach( var item in Model.Items )
           { %>
        
            <div style="display: table-row;">
                <div class="w200" style="display: table-cell;"><%= Html.Encode(item.Name) %></div>
                <div class="w100" style="display: table-cell;"><%= Html.Encode(item.Price) %> x <%= item.Quantity %></div>
                <div class="w100" style="display: table-cell;"><%= Html.Encode(item.Price * item.Quantity) %></div>
                <div class="w250">
                    <% if(item.Debtors == null){ %>
                        <strong>Shared</strong>
                    <% }else{ %>
                        <%= string.Join(", ", item.Debtors.ToArray()) %>
                    <% } %>
                </div>
            </div>
        
        <% } %>
        <div class="w400" style="text-align: right;"><%= Model.TotalSum %></div>
        </div>
    <% } %>

</asp:Content>
