<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="QuickHost.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- <section style="width: 500px; height: 300px;">
      <img src="imgs/xy.jpg" class="img-fluid" style="width: 365%; height: 106%;" />
       
   </section>-->
    <section class="section-container">
        <img src="imgs/1.jpg" class="img-fluid" />
        <div class="a1">
            <h1>HOST YOUR WEBSITE HERE Akshay choudhary</h1>
        </div>
    </section>
    <section class="sec-cor">
        <img src="imgs/1.jpg" class="img-fluid" />
        <div class="b1">
            <h3>Interested in Private, Secure and Anonymous Online Browsing?</h3>
        </div>
    </section>
    <section class="card-container">
        <div class="card left">
            <div class="card-body">
                <h5 class="card-title">Dynamic DNS</h5>
                <p class="card-text">
                    Dynamic DNS is a convenient and cost-effective solution for maintaining accessibility to your website, particularly if you're hosting it on a server with a dynamic IP address. By automatically updating DNS records, dynamic DNS ensures that visitors can always reach your website without disruption.
                </p>
            </div>
        </div>
        <div class="card middle">
            <div class="card-body">
                <h5 class="card-title" >Domain</h5>
                <p class="card-text">
                    A Domain is a fundamental component of the internet infrastructure, providing a way to identify and access online resources. It plays a crucial role in web navigation, branding, and establishing an online presence for individuals, businesses, and organizations.
                </p>
            </div>
        </div>
        <div class="card right">
            <div class="card-body">
                <h5 class="card-title">VPN</h5>
                <p class="card-text">
                    VPNs offer users enhanced privacy, security, and flexibility when accessing the internet or private networks. By encrypting data, masking IP addresses, and providing secure connections, VPNs enable users to browse the web safely, access restricted content, and connect to private networks from anywhere in the world.
                </p>
            </div>
        </div>
    </section>
   <section class="content-section">
    <div class="content">
        <h2>What is Dynamic DNS?</h2>
        <p class="paragraph-text">
             Dynamic DNS makes a dynamic IP address act like it is a static IP address, meaning it does not change. It does this by utilizing a hostname and our Dynamic Update Client to keep your hostname updated with the correct IP address.
        </p>
    </div>
</section>



</asp:Content>
