#SOLID
Set of principle given by Robert.C.Martin.
Allows building SOLID software system.
SOLID principles are related with the design and maintenance of software system
SOLID software system means its allows to build system that is
Easy to maintain
Easy to extend
Easy to understand
Easy to implement
Easy to explain</p>

#SRP (Single Responsibility Principle)
Single responsibility state that a class should have one, and only one, reason to change.
	 public class Employee
	 {
	     public int Employee_Id { get; set; }
	     public string Employee_Name { get; set; }

	     public bool InsertIntoEmployeeTable(Employee em)
	     {
			 // Write your code here
		 return true;
	     }
	     public void GenerateReport(Employee em)
	     {
		 // Report generation with employee data using crystal report.
	     }
	 }

	Solution#
	 public class Employee
	 {
	       public int Employee_Id { get; set; }
	       public string Employee_Name { get; set; }

	       public bool InsertIntoEmployeeTable(Employee em)
	       {
		    // Write your code here
		  return true;
	       }
	 }

	 public class ReportGeneration
	 {
	       public void GenerateReport(Employee em)
	       {
		    // Report reneration with employee data.
	       }
	 }

<h1><a id="user-content-ocp-open-closed-principle" class="anchor" aria-hidden="true" href="#ocp-open-closed-principle"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>OCP (Open-Closed Principle)</h1>
<p>Open close principle state that a software module/class is open for extension and closed for modification</p>
<pre><code>  public class ReportGeneration
  {
     public void GenerateReport(Employee em)
     {
	 if (ReportType == "CRS")
	 {
	      // Report generation with employee data in Crystal Report.
	 }
	 if (ReportType == "PDF")
	 {
	     // Report generation with employee data in PDF.
	 }
      }
  }
</code></pre>
<p>Solution</p>
<pre><code>public class IReportGeneration
{
    public virtual void GenerateReport(Employee em)
    {
	// From base
    }
}

public class CrystalReportGeneraion : IReportGeneration
{
    public override void GenerateReport(Employee em)
    {
	// Generate crystal report.
    }
}

public class PDFReportGeneraion : IReportGeneration
{
    public override void GenerateReport(Employee em)
    {
	// Generate PDF report.
    }
}			
</code></pre>
<h1><a id="user-content-lsp-liskovs-substitution-principle" class="anchor" aria-hidden="true" href="#lsp-liskovs-substitution-principle"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>LSP (Liskov's Substitution Principle)</h1>
<p>The Liskov Substitution Principle (LSP) states that "you should be able to use any derived class instead of a parent class and have it
behave in the same manner without modification". It ensures that a derived class does not affect the behavior of the parent class,
in other words that a derived class must be substitutable for its base class</p>
<p>Problem</p>
<pre><code>	public abstract class Employee
	{
	    public virtual string GetProjectDetails(int employeeId)
	    {
		return "Base Project";
	    }
	    public virtual string GetEmployeeDetails(int employeeId)
	    {
		return "Base Employee";
	    }
	}
	public class CasualEmployee : Employee
	{
	    public override string GetProjectDetails(int employeeId)
	    {
		return "Child Project";
	    }
	    // May be for contractual employee we do not need to store the details into database.
	    public override string GetEmployeeDetails(int employeeId)
	    {
		return "Child Employee";
	    }
	}
	public class ContractualEmployee : Employee
	{
	    public override string GetProjectDetails(int employeeId)
	    {
		return "Child Project";
	    }
	    // May be for contractual employee we do not need to store the details into database.
	    public override string GetEmployeeDetails(int employeeId)
	    {
		throw new NotImplementedException();
	    }
	}

	List&lt;Employee&gt; employeeList = new List&lt;Employee&gt;();
	employeeList.Add(new ContractualEmployee());
	employeeList.Add(new CasualEmployee());
	foreach (Employee e in employeeList)
	{
	    e.GetEmployeeDetails(1245);
	}
</code></pre>
<p>Solutions</p>
<pre><code>     public interface IEmployee
     {
	 string GetEmployeeDetails(int employeeId);
     }

     public interface IProject
     {
	 string GetProjectDetails(int employeeId);
     }
</code></pre>
<h1><a id="user-content-isp-interface-segregation-principle" class="anchor" aria-hidden="true" href="#isp-interface-segregation-principle"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>ISP (Interface Segregation Principle)</h1>
<p>Clients should not be forced to implement interfaces they don't use. Instead of one fat interface many small interfaces are preferred
based on groups of methods, each one serving one sub module.</p>
<p>Problem</p>
<pre><code> Interface ISavingAccount  
 {  
    //Other method and property and code  
    bool Withdrwal(decimal amount);  
 }  

 Public Class RegularSavingAccount : ISavingAccount  
 {  
   //Other method and property and code related to Regular Saving account  
    Public bool Withdrwal ()  
   {  
     Decimal moneyAfterWithdrawal = Balance-amount;  
     if(moneyAfterWithdrawal &gt;= 1000)  
     {  
        //update balace   
        return true;  
     }  
    else  
      return false;  
   }  
 }  

 Public Class SalarySavingAccount : ISavingAccount  
 {  
   //Other method and property and code related to Salary Saving account`  
    Public bool Withdrwal ()  
   {  
     Decimal moneyAfterWithdrawal = Balance-amount;  
     if(moneyAfterWithdrawal &gt;= 0)  
     {  
        //update balace   
        return true;  
     }  
     else  
        return false;  
   }  
 }  

 Public Class FixDepositSavingAccount : ISavingAccount  
 {  
   //Other method and property and code related to Salary Saving account`  
    Public bool Withdrwal ()  
    {  
      Throw New Excpetion("Not supported by this account type");  
    }  
 }
 
 Public class AccountManager  
 {  
   Public bool WithdrawFromAccount(IsavingAccount account)  
   {  
     account.Withdraw(amount);  
   }  
 }
 
 //works ok  
 AccountManager.WidhdrawFromAccount(new RegularSavingAccount());  
 //works ok  
 AccountManager.WidhdrawFromAccount(new SalarySavingAccount());  
 //throws exception as withdrawal is not supported  
 AccountManager.WidhdrawFromAccount(new FixDepositSavingAccount());
</code></pre>
<p>Solution</p>
<pre><code> Interface ISavingAccount  
 {
 
 }  

 Public Class SavingAccountWithWithdrawal : ISavingAccount  
 {  
     Public virtual bool Withdrwal () {}  
 }  

 Public Class SavingAccountWithoutWithdrawal : ISavingAccount  
 {  

 }  

 Public Class RegularSavingAccount : SavingAccountWithWithdrawal  
 {   

   Public bool Withdrwal ()  
   { 
      //implementation  
   }  
 }  

 Public Class SalarySavingAccount : SavingAccountWithWithdrawal  
 {   
   Public bool Withdrwal ()  
   {//implementation  
   }  
 }  

 Public Class FixDepositSavingAccount : SavingAccountWithoutWithdrawal  
 {  

 }
 
 Public class AccountManager  
 {  

    Public bool WithdrawFromAccount(SavingAccountWithWithdrawal account)  
    {  
       account.Withdraw(amount);  
    }  
 }
 
 //works ok  
 AccountManager.WidhdrawFromAccount(new RegularSavingAccount());  
 //works ok  
 AccountManager.WidhdrawFromAccount(new SalarySavingAccount());  
 //compiler gives error   
 AccountManager.WidhdrawFromAccount(new FixDepositSavingAccount());
</code></pre>
<h1><a id="user-content-dip-dependency-injectioninversion" class="anchor" aria-hidden="true" href="#dip-dependency-injectioninversion"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>DIP (Dependency Injection/Inversion)</h1>
<p>High-level modules/classes should not depend upon low-level modules/classes. Both should depend upon abstractions. Secondly,
abstractions should not depend upon details. Details should depend upon abstractions.</p>
<pre><code> public class Email
 {
     public void SendEmail()
     {
         // code to send mail
     }
 }

 public class Notification
 {
     private Email _email;
     public Notification()
     {
         _email = new Email();
     }

     public void PromotionalNotification()
     {
         _email.SendEmail();
     }
 }
</code></pre>
<p>Now Notification class totally depends on Email class, because it only sends one type of notification. If we want to introduce any other like SMS then? We need to change the notification system also. And this is called tightly coupled. What can we do to make it loosely coupled? Ok, check the following implementation.</p>
<pre><code> public interface IMessenger
 {
     void SendMessage();
 }
 public class Email : IMessenger
 {
     public void SendMessage()
     {
         // code to send email
     }
 }

 public class SMS : IMessenger
 {
     public void SendMessage()
     {
         // code to send SMS
     }
 }
 public class Notification
 {
     private IMessenger _iMessenger;
     public Notification()
     {
         _ iMessenger = new Email();
     }
     public void DoNotify()
     {
         _ iMessenger.SendMessage();
     }
 }
</code></pre>
<p>Still Notification class depends on Email class. Now, we can use dependency injection so that we can make it loosely coupled.
There are 3 types to DI, Constructor injection, Property injection and method injection.</p>
<p>Constructor Injection</p>
<pre><code> public class Notification
 {
     private IMessenger _iMessenger;
     public Notification(Imessenger pMessenger)
     {
         _ iMessenger = pMessenger;
     }
     public void DoNotify()
     {
         _ iMessenger.SendMessage();
     }
 }
</code></pre>
<p>Property Injection</p>
<pre><code> public class Notification
 {
     private IMessenger _iMessenger;

     public Notification()
     {
     }
     public IMessenger MessageService
     {
        private get;
        set
        {
            _ iMessenger = value;
        }
      }

     public void DoNotify()
     {
         _ iMessenger.SendMessage();
     }
 }
</code></pre>
<p>Method Injection</p>
<pre><code> public class Notification
 {
     public void DoNotify(IMessenger pMessenger)
     {
         pMessenger.SendMessage();
     }
 }
</code></pre>
<p>For more detils follow</p>
<p><a href="https://www.codeproject.com/Tips/1033646/SOLID-Principle-with-Csharp-Example" rel="nofollow">https://www.codeproject.com/Tips/1033646/SOLID-Principle-with-Csharp-Example</a></p>
</article>
  </div>

  </div>

  <details class="details-reset details-overlay details-overlay-dark">
    <summary data-hotkey="l" aria-label="Jump to line"></summary>
    <details-dialog class="Box Box--overlay d-flex flex-column anim-fade-in fast linejump" aria-label="Jump to line">
      <!-- '"` --><!-- </textarea></xmp> --></option></form><form class="js-jump-to-line-form Box-body d-flex" action="" accept-charset="UTF-8" method="get"><input name="utf8" type="hidden" value="&#x2713;" />
        <input class="form-control flex-auto mr-3 linejump-input js-jump-to-line-field" type="text" placeholder="Jump to line&hellip;" aria-label="Jump to line" autofocus>
        <button type="submit" class="btn" data-close-dialog>Go</button>
</form>    </details-dialog>
  </details>


  </div>
  <div class="modal-backdrop js-touch-events"></div>
</div>

    </div>
  </div>

  </div>

        
<div class="footer container-lg px-3" role="contentinfo">
  <div class="position-relative d-flex flex-justify-between pt-6 pb-2 mt-6 f6 text-gray border-top border-gray-light ">
    <ul class="list-style-none d-flex flex-wrap ">
      <li class="mr-3">&copy; 2018 <span title="0.31277s from unicorn-97c56659f-bxkr6">GitHub</span>, Inc.</li>
        <li class="mr-3"><a data-ga-click="Footer, go to terms, text:terms" href="https://github.com/site/terms">Terms</a></li>
        <li class="mr-3"><a data-ga-click="Footer, go to privacy, text:privacy" href="https://github.com/site/privacy">Privacy</a></li>
        <li class="mr-3"><a href="https://help.github.com/articles/github-security/" data-ga-click="Footer, go to security, text:security">Security</a></li>
        <li class="mr-3"><a href="https://status.github.com/" data-ga-click="Footer, go to status, text:status">Status</a></li>
        <li><a data-ga-click="Footer, go to help, text:help" href="https://help.github.com">Help</a></li>
    </ul>

    <a aria-label="Homepage" title="GitHub" class="footer-octicon" href="https://github.com">
      <svg height="24" class="octicon octicon-mark-github" viewBox="0 0 16 16" version="1.1" width="24" aria-hidden="true"><path fill-rule="evenodd" d="M8 0C3.58 0 0 3.58 0 8c0 3.54 2.29 6.53 5.47 7.59.4.07.55-.17.55-.38 0-.19-.01-.82-.01-1.49-2.01.37-2.53-.49-2.69-.94-.09-.23-.48-.94-.82-1.13-.28-.15-.68-.52-.01-.53.63-.01 1.08.58 1.23.82.72 1.21 1.87.87 2.33.66.07-.52.28-.87.51-1.07-1.78-.2-3.64-.89-3.64-3.95 0-.87.31-1.59.82-2.15-.08-.2-.36-1.02.08-2.12 0 0 .67-.21 2.2.82.64-.18 1.32-.27 2-.27.68 0 1.36.09 2 .27 1.53-1.04 2.2-.82 2.2-.82.44 1.1.16 1.92.08 2.12.51.56.82 1.27.82 2.15 0 3.07-1.87 3.75-3.65 3.95.29.25.54.73.54 1.48 0 1.07-.01 1.93-.01 2.2 0 .21.15.46.55.38A8.013 8.013 0 0 0 16 8c0-4.42-3.58-8-8-8z"/></svg>
</a>
   <ul class="list-style-none d-flex flex-wrap ">
        <li class="mr-3"><a data-ga-click="Footer, go to contact, text:contact" href="https://github.com/contact">Contact GitHub</a></li>
      <li class="mr-3"><a href="https://developer.github.com" data-ga-click="Footer, go to api, text:api">API</a></li>
      <li class="mr-3"><a href="https://training.github.com" data-ga-click="Footer, go to training, text:training">Training</a></li>
      <li class="mr-3"><a href="https://shop.github.com" data-ga-click="Footer, go to shop, text:shop">Shop</a></li>
        <li class="mr-3"><a href="https://blog.github.com" data-ga-click="Footer, go to blog, text:blog">Blog</a></li>
        <li><a data-ga-click="Footer, go to about, text:about" href="https://github.com/about">About</a></li>

    </ul>
  </div>
  <div class="d-flex flex-justify-center pb-6">
    <span class="f6 text-gray-light"></span>
  </div>
</div>



  <div id="ajax-error-message" class="ajax-error-message flash flash-error">
    <svg class="octicon octicon-alert" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M8.893 1.5c-.183-.31-.52-.5-.887-.5s-.703.19-.886.5L.138 13.499a.98.98 0 0 0 0 1.001c.193.31.53.501.886.501h13.964c.367 0 .704-.19.877-.5a1.03 1.03 0 0 0 .01-1.002L8.893 1.5zm.133 11.497H6.987v-2.003h2.039v2.003zm0-3.004H6.987V5.987h2.039v4.006z"/></svg>
    <button type="button" class="flash-close js-ajax-error-dismiss" aria-label="Dismiss error">
      <svg class="octicon octicon-x" viewBox="0 0 12 16" version="1.1" width="12" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M7.48 8l3.75 3.75-1.48 1.48L6 9.48l-3.75 3.75-1.48-1.48L4.52 8 .77 4.25l1.48-1.48L6 6.52l3.75-3.75 1.48 1.48L7.48 8z"/></svg>
    </button>
    You can’t perform that action at this time.
  </div>


    
    <script crossorigin="anonymous" integrity="sha512-MMf7GwM+L5Gyt9uiyH+dgfRMKe3MvokMsK8rmZ7miC4hQRLp/SFC1p9FQF64rH4238QIetIh02tl1O9BqBVTsg==" type="application/javascript" src="https://assets-cdn.github.com/assets/frameworks-6b835006a412df5637ae735f7e380290.js"></script>
    
    <script crossorigin="anonymous" async="async" integrity="sha512-zojl8W2VaCZ91tvHV+/UcgJBVxYXhDkU7l4PZoXkgImmJzULu1U3g71IsmIyApV0CTreyFS+eqR27vzwfyxyMA==" type="application/javascript" src="https://assets-cdn.github.com/assets/github-bb2ce11c0eb7e50f29f21a96865d8266.js"></script>
    
    
    
  <div class="js-stale-session-flash stale-session-flash flash flash-warn flash-banner d-none">
    <svg class="octicon octicon-alert" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M8.893 1.5c-.183-.31-.52-.5-.887-.5s-.703.19-.886.5L.138 13.499a.98.98 0 0 0 0 1.001c.193.31.53.501.886.501h13.964c.367 0 .704-.19.877-.5a1.03 1.03 0 0 0 .01-1.002L8.893 1.5zm.133 11.497H6.987v-2.003h2.039v2.003zm0-3.004H6.987V5.987h2.039v4.006z"/></svg>
    <span class="signed-in-tab-flash">You signed in with another tab or window. <a href="">Reload</a> to refresh your session.</span>
    <span class="signed-out-tab-flash">You signed out in another tab or window. <a href="">Reload</a> to refresh your session.</span>
  </div>
  <div class="facebox" id="facebox" style="display:none;">
  <div class="facebox-popup">
    <div class="facebox-content" role="dialog" aria-labelledby="facebox-header" aria-describedby="facebox-description">
    </div>
    <button type="button" class="facebox-close js-facebox-close" aria-label="Close modal">
      <svg class="octicon octicon-x" viewBox="0 0 12 16" version="1.1" width="12" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M7.48 8l3.75 3.75-1.48 1.48L6 9.48l-3.75 3.75-1.48-1.48L4.52 8 .77 4.25l1.48-1.48L6 6.52l3.75-3.75 1.48 1.48L7.48 8z"/></svg>
    </button>
  </div>
</div>

  <div class="Popover js-hovercard-content position-absolute" style="display: none; outline: none;" tabindex="0">
  <div class="Popover-message Popover-message--bottom-left Popover-message--large Box box-shadow-large" style="width:360px;">
  </div>
</div>

<div id="hovercard-aria-description" class="sr-only">
  Press h to open a hovercard with more details.
</div>


  </body>
</html>

