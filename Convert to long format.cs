using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;
using Microsoft.Xrm.Sdk.Workflow;
using Microsoft.Xrm.Sdk;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;

namespace WalkersD365_Workflow_Activity___Convert_date_to_long_date_format
{
    public class Convert_to_long_format : CodeActivity
    {
        [RequiredArgument]
        [Input("Booking Date")]
        public InArgument<DateTime> BookingDate { get; set; }

        [Output("Formatted Text")]
        public OutArgument<string> TextFormatted { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            IWorkflowContext workflowContext = context.GetExtension<IWorkflowContext>();
            this.TextFormatted.Set(context, this.BookingDate.Get<DateTime>(context).ToLongDateString());

        }
    }
}
