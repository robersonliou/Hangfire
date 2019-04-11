#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hangfire.Dashboard.Pages
{
    
    #line 2 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using System;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    using System.Linq;
    using System.Text;
    
    #line 4 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using Hangfire;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using Hangfire.Dashboard;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using Hangfire.Dashboard.Pages;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using Hangfire.Dashboard.Resources;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using Hangfire.States;
    
    #line default
    #line hidden
    
    #line 9 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using Hangfire.Storage;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class RecurringJobsPage : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");











            
            #line 11 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
  
    Layout = new LayoutPage(Strings.RecurringJobsPage_Title);
	List<RecurringJobDto> recurringJobs;
    
    int from, perPage;

    int.TryParse(Query("from"), out from);
    int.TryParse(Query("count"), out perPage);

    Pager pager = null;

	using (var connection = Storage.GetConnection())
	{
	    var storageConnection = connection as JobStorageConnection;
	    if (storageConnection != null)
	    {
	        pager = new Pager(from, perPage, storageConnection.GetRecurringJobCount());
	        recurringJobs = storageConnection.GetRecurringJobs(pager.FromRecord, pager.FromRecord + pager.RecordsPerPage - 1);
	    }
	    else
	    {
            recurringJobs = connection.GetRecurringJobs();
	    }
	}


            
            #line default
            #line hidden
WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <h1 class=\"page-header\"" +
">");


            
            #line 39 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                           Write(Strings.RecurringJobsPage_Title);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n");


            
            #line 40 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
         if (recurringJobs.Count == 0)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"alert alert-info\">\r\n                ");


            
            #line 43 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
           Write(Strings.RecurringJobsPage_NoJobs);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");


            
            #line 45 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"js-jobs-list\">\r\n                <div class=\"btn-toolbar b" +
"tn-toolbar-top\">\r\n");


            
            #line 50 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                     if (!IsReadOnly)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <button class=\"js-jobs-list-command btn btn-sm btn-primar" +
"y\"\r\n                                data-url=\"");


            
            #line 53 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                     Write(Url.To("/recurring/trigger"));

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                                data-loading-text=\"");


            
            #line 54 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                              Write(Strings.RecurringJobsPage_Triggering);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                                disabled=\"disabled\">\r\n                        " +
"    <span class=\"glyphicon glyphicon-play-circle\"></span>\r\n                     " +
"       ");


            
            #line 57 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                       Write(Strings.RecurringJobsPage_TriggerNow);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </button>\r\n");


            
            #line 59 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                    }

            
            #line default
            #line hidden

            
            #line 60 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                     if (!IsReadOnly)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <button class=\"js-jobs-list-command btn btn-sm btn-defaul" +
"t\"\r\n                                data-url=\"");


            
            #line 63 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                     Write(Url.To("/recurring/remove"));

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                                data-loading-text=\"");


            
            #line 64 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                              Write(Strings.Common_Deleting);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                                data-confirm=\"");


            
            #line 65 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                         Write(Strings.Common_DeleteConfirm);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                                disabled=\"disabled\">\r\n                        " +
"    <span class=\"glyphicon glyphicon-remove\"></span>\r\n                          " +
"  ");


            
            #line 68 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                       Write(Strings.Common_Delete);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </button>\r\n");


            
            #line 70 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                    }

            
            #line default
            #line hidden

            
            #line 71 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                     if (pager != null)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        ");

WriteLiteral(" ");


            
            #line 73 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                      Write(Html.PerPageSelector(pager));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 74 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </div>\r\n\r\n                <div class=\"table-responsive\">\r\n       " +
"             <table class=\"table\">\r\n                        <thead>\r\n           " +
"                 <tr>\r\n");


            
            #line 81 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                 if (!IsReadOnly)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <th class=\"min-width\">\r\n                     " +
"                   <input type=\"checkbox\" class=\"js-jobs-list-select-all\"/>\r\n   " +
"                                 </th>\r\n");


            
            #line 86 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                                <th class=\"min-width\">");


            
            #line 87 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                 Write(Strings.Common_Id);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                <th class=\"min-width\">");


            
            #line 88 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                 Write(Strings.RecurringJobsPage_Table_Cron);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                <th class=\"min-width\">");


            
            #line 89 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                 Write(Strings.RecurringJobsPage_Table_TimeZone);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                <th>");


            
            #line 90 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                               Write(Strings.Common_Job);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                <th class=\"align-right min-width\">");


            
            #line 91 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                             Write(Strings.RecurringJobsPage_Table_NextExecution);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                <th class=\"align-right min-width\">");


            
            #line 92 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                             Write(Strings.RecurringJobsPage_Table_LastExecution);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                <th class=\"align-right min-width\">");


            
            #line 93 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                             Write(Strings.Common_Created);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                            </tr>\r\n                        </thead>\r\n     " +
"                   <tbody>\r\n");


            
            #line 97 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                             foreach (var job in recurringJobs)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <tr class=\"js-jobs-list-row hover\">\r\n");


            
            #line 100 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                     if (!IsReadOnly)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <td>\r\n                                   " +
"         <input type=\"checkbox\" class=\"js-jobs-list-checkbox\" name=\"jobs[]\" valu" +
"e=\"");


            
            #line 103 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                                                                 Write(job.Id);

            
            #line default
            #line hidden
WriteLiteral("\"/>\r\n                                        </td>\r\n");


            
            #line 105 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                    <td class=\"min-width\">");


            
            #line 106 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                     Write(job.Id);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                    <td class=\"min-width\">\r\n              " +
"                          ");



WriteLiteral("\r\n");


            
            #line 109 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                          
                                            string cronDescription = null;
                                            bool cronError = false;

                                            if (!String.IsNullOrEmpty(job.Cron))
                                            {
                                                try
                                                {
                                                    RecurringJobEntity.ParseCronExpression(job.Cron);
                                                }
                                                catch (Exception ex)
                                                {
                                                    cronDescription = ex.Message;
                                                    cronError = true;
                                                }

                                                if (cronDescription == null)
                                                {
#if FEATURE_CRONDESCRIPTOR
                                                    try
                                                    {
                                                        cronDescription = CronExpressionDescriptor.ExpressionDescriptor.GetDescription(job.Cron);
                                                    }
                                                    catch (FormatException)
                                                    {
                                                    }
#endif
                                                }
                                            }
                                        

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 140 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                         if (cronDescription != null)
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                        <code title=\"");


            
            #line 142 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                Write(cronDescription);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n");


            
            #line 143 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                             if (cronError)
                                            {

            
            #line default
            #line hidden
WriteLiteral("                                                <span class=\"glyphicon glyphicon-" +
"exclamation-sign\"></span>\r\n");


            
            #line 146 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                            }

            
            #line default
            #line hidden
WriteLiteral("                                            ");


            
            #line 147 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                       Write(job.Cron);

            
            #line default
            #line hidden
WriteLiteral("\r\n                                        </code>\r\n");


            
            #line 149 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                        }
                                        else
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <code>");


            
            #line 152 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                             Write(job.Cron);

            
            #line default
            #line hidden
WriteLiteral("</code>\r\n");


            
            #line 153 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </td>\r\n                                    <t" +
"d class=\"min-width\">\r\n");


            
            #line 156 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                         if (!String.IsNullOrWhiteSpace(job.TimeZoneId))
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <span title=\"");


            
            #line 158 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                    Write(TimeZoneInfo.FindSystemTimeZoneById(job.TimeZoneId).DisplayName);

            
            #line default
            #line hidden
WriteLiteral("\" data-container=\"body\">");


            
            #line 158 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                                                                                            Write(job.TimeZoneId);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");


            
            #line 159 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                        }
                                        else
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            ");

WriteLiteral(" UTC\r\n");


            
            #line 163 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </td>\r\n                                    <t" +
"d class=\"word-break\">\r\n");


            
            #line 166 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                         if (job.Job != null)
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            ");

WriteLiteral(" ");


            
            #line 168 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                          Write(Html.JobName(job.Job));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 169 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                        }
                                        else if (job.LoadException != null && job.LoadException.InnerException != null)
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <em>");


            
            #line 172 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                           Write(job.LoadException.InnerException.Message);

            
            #line default
            #line hidden
WriteLiteral("</em>\r\n");


            
            #line 173 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                        }
                                        else if (job.LoadException != null)
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <em>");


            
            #line 176 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                           Write(job.LoadException.Message);

            
            #line default
            #line hidden
WriteLiteral("</em>\r\n");


            
            #line 177 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                        }
                                        else
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <em>");


            
            #line 180 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                           Write(Strings.Common_NotAvailable);

            
            #line default
            #line hidden
WriteLiteral("</em>\r\n");


            
            #line 181 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </td>\r\n                                    <t" +
"d class=\"align-right min-width\">\r\n");


            
            #line 184 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                         if (job.NextExecution != null)
                                        {
                                            
            
            #line default
            #line hidden
            
            #line 186 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                       Write(Html.RelativeTime(job.NextExecution.Value));

            
            #line default
            #line hidden
            
            #line 186 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                                       
                                        }
                                        else
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <span class=\"label label-warning text" +
"-uppercase\" title=\"");


            
            #line 190 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                                               Write(Strings.RecurringJobsPage_RecurringJobDisabled_Tooltip);

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 190 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                                                                                                        Write(Strings.Common_Disabled);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");


            
            #line 191 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </td>\r\n                                    <t" +
"d class=\"align-right min-width\">\r\n");


            
            #line 194 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                         if (job.LastExecution != null)
                                        {
                                            if (!String.IsNullOrEmpty(job.LastJobId))
                                            {

            
            #line default
            #line hidden
WriteLiteral("                                                <a href=\"");


            
            #line 198 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                    Write(Url.JobDetails(job.LastJobId));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                                    <span class=\"label label-" +
"default label-hover\" style=\"");


            
            #line 199 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                                                     Write($"background-color: {JobHistoryRenderer.GetForegroundStateColor(job.LastJobState ?? EnqueuedState.StateName)};");

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                                        ");


            
            #line 200 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                   Write(Html.RelativeTime(job.LastExecution.Value));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                                    </span>\r\n                  " +
"                              </a>\r\n");


            
            #line 203 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                            }
                                            else
                                            {

            
            #line default
            #line hidden
WriteLiteral("                                                <em>\r\n                           " +
"                         ");


            
            #line 207 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                               Write(Strings.RecurringJobsPage_Canceled);

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 207 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                                   Write(Html.RelativeTime(job.LastExecution.Value));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                                </em>\r\n");


            
            #line 209 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                            }
                                        }
                                        else
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <em>");


            
            #line 213 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                           Write(Strings.Common_NotAvailable);

            
            #line default
            #line hidden
WriteLiteral("</em>\r\n");


            
            #line 214 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </td>\r\n                                    <t" +
"d class=\"align-right min-width\">\r\n");


            
            #line 217 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                         if (job.CreatedAt != null)
                                        {
                                            
            
            #line default
            #line hidden
            
            #line 219 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                       Write(Html.RelativeTime(job.CreatedAt.Value));

            
            #line default
            #line hidden
            
            #line 219 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                                   
                                        }
                                        else
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <em>N/A</em>\r\n");


            
            #line 224 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </td>\r\n                                </tr>\r" +
"\n");


            
            #line 227 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                             }

            
            #line default
            #line hidden
WriteLiteral("                        </tbody>\r\n                    </table>\r\n                <" +
"/div>\r\n\r\n");


            
            #line 232 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                 if (pager != null)
                {

            
            #line default
            #line hidden
WriteLiteral("                    ");

WriteLiteral(" ");


            
            #line 234 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                  Write(Html.Paginator(pager));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 235 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n");


            
            #line 237 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>    ");


        }
    }
}
#pragma warning restore 1591