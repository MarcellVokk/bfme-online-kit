# Bfme Foundation Project - OnlineKit

#### In this repository you will find everything you need to implement Online Arena into your own project.

## WPF Implementation
<a href="https://www.nuget.org/packages/BfmeFoundationProject.OnlineKit">
    <img src="https://img.shields.io/nuget/v/BfmeFoundationProject.OnlineKit"/>
</a>

- Install the `BfmeFoundationProject.OnlineKit` NuGet Package.
- Reference the namespace in the desired XAML file (`xmlns:onlineKit="clr-namespace:BfmeFoundationProject.OnlineKit;assembly=BfmeFoundationProject.OnlineKit"`)
- Add the `OnlineMenu` element to your design (`<onlineKit:OnlineMenu x:Name="onlineMenu" AccessToken="{YOUR_APPLICATION_ACCESS_TOKEN}"/>`)

 ## Usage
 - Enter your applications access token in the `AccessToken` field
 - Load Arena by calling the `Load()` function. You can optionaly pass in a `BfmeGame game` as an argument. When Arena loads, this will be the initial game selected.
 - You can also unload Arena by calling the `Unload()` function

## Updates
- Arena itself has an automatic update system, you don't have to worry about that
- Ensuring Online Kit is always up to date in your projects is your responsibility as a developer, but we will always try to reach out if an update is available!
- In the `UpdateBranch` field of the OnlineMenu element, you can specify which branch Arena should pull it's updates from. **This is curently not used**, we only have the main branch, but might be used to deliver experimental versions of Online Arena to users who opt in.

## Access Tokens
- In order for your app to connect to our services and for Arena to work, you have to specify a valid Access Token in the `AccessToken` field of the OnlineMenu element.
- You can obtain an Access Token by sending us an email at `bfme109team@gmail.com`. In your email, please include the name of your application, the name and contact info of the developer (or someone from your team who we can contact), and all other information about your application you can provide (screenshots, github links, project website, or even a build of your app). Every serious request will be reviewed individualy by us, and if we approve your request, we will send a followup email containing your Access Token. **One Access Token is only allowed to be used by one application!**
- Every Access Token is associated with one specific application, and can be revoked - without any notice or explanation - by us at any time.
- Sharing your Access Token with someone, or using an Access Token that is not for your application, will result in your Access Token being revoked.

## Examples
You can find both a WPF and a WinForms example in this repository.
Note: Neither example has a valid access token, so you won't be able to connect to the servers. This is normal.

###### Developed by: Gazdag Marcell (*@marcellvokk*)<br> Founder & Owner: Beterwell (*@Beterwell*)<br>Testing: Beterwell (*@Beterwell*), Yoshi (*@y0shi8762*), Necromancer (*@necromancer393*), CROAT (*@CROAT#9413*), x6tenceGB2 (*@x6tencegb2*), martinms600 (*@martinms600*), Tristan (*@tristan_sc*), Dunedain (*@dunedain412*), RANJEL (*@ranjel*), Fishy (*@fishy_bfme*), and others...
