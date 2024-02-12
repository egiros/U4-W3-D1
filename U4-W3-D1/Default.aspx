<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="U4_W3_D1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>

        <div class="text-center mt-5">
            <h2>Visualizza Candidato</h2>
            <h5>Premi il tasto per visualizzare Nome e Cognome Candidato</h5>
                 <asp:Button ID="btnVisualizza" CssClass="btn btn-primary my-5" runat="server" Text="Visualizza" OnClick="btnVisualizza_Click" />
                 <br />
                 <asp:Label ID="NomeCandidato" CssClass="display-6 mb-5" runat="server" Text=""></asp:Label>
                 <asp:Label ID="CognomeCandidato" CssClass="display-6" runat="server" Text=""></asp:Label>
 
        </div>

    </main>

</asp:Content>
