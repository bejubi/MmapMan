namespace MmapManager.Console.Activity {
    
    #line 21 "C:\dev\development\Sandbox\MmapMan\MmapManager\MmapManager.Console\Activity\ProcessStep.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\dev\development\Sandbox\MmapMan\MmapManager\MmapManager.Console\Activity\ProcessStep.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 22 "C:\dev\development\Sandbox\MmapMan\MmapManager\MmapManager.Console\Activity\ProcessStep.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\dev\development\Sandbox\MmapMan\MmapManager\MmapManager.Console\Activity\ProcessStep.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\dev\development\Sandbox\MmapMan\MmapManager\MmapManager.Console\Activity\ProcessStep.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\dev\development\Sandbox\MmapMan\MmapManager\MmapManager.Console\Activity\ProcessStep.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 23 "C:\dev\development\Sandbox\MmapMan\MmapManager\MmapManager.Console\Activity\ProcessStep.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 24 "C:\dev\development\Sandbox\MmapMan\MmapManager\MmapManager.Console\Activity\ProcessStep.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 25 "C:\dev\development\Sandbox\MmapMan\MmapManager\MmapManager.Console\Activity\ProcessStep.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 1 "C:\dev\development\Sandbox\MmapMan\MmapManager\MmapManager.Console\Activity\ProcessStep.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class ProcessStep : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
        private System.Activities.Activity rootActivity;
        
        private object dataContextActivities;
        
        private bool forImplementation = true;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public string GetLanguage() {
            return "C#";
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((this.dataContextActivities == null)) {
                this.dataContextActivities = ProcessStep_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ProcessStep_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext0 = ((ProcessStep_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new ProcessStep_TypedDataContext2(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2 refDataContext1 = ((ProcessStep_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext1.GetLocation<string>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ProcessStep_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext2 = ((ProcessStep_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new ProcessStep_TypedDataContext2(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2 refDataContext3 = ((ProcessStep_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext3.GetLocation<string>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ProcessStep_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext4 = ((ProcessStep_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new ProcessStep_TypedDataContext2(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2 refDataContext5 = ((ProcessStep_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext5.GetLocation<string>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ProcessStep_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext6 = ((ProcessStep_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new ProcessStep_TypedDataContext2(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2 refDataContext7 = ((ProcessStep_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext7.GetLocation<bool>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ProcessStep_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext8 = ((ProcessStep_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ProcessStep_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext9 = ((ProcessStep_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ProcessStep_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext10 = ((ProcessStep_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ProcessStep_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext11 = ((ProcessStep_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new ProcessStep_TypedDataContext2(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2 refDataContext12 = ((ProcessStep_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext12.GetLocation<string>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ProcessStep_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext13 = ((ProcessStep_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new ProcessStep_TypedDataContext2(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2 refDataContext14 = ((ProcessStep_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext14.GetLocation<bool>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ProcessStep_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext15 = ((ProcessStep_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ProcessStep_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext16 = ((ProcessStep_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ProcessStep_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext17 = ((ProcessStep_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new ProcessStep_TypedDataContext2(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2 refDataContext18 = ((ProcessStep_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext18.GetLocation<bool>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ProcessStep_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext19 = ((ProcessStep_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new ProcessStep_TypedDataContext2(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2 refDataContext20 = ((ProcessStep_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext20.GetLocation<bool>(refDataContext20.ValueType___Expr20Get, refDataContext20.ValueType___Expr20Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ProcessStep_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext21 = ((ProcessStep_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ProcessStep_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext22 = ((ProcessStep_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ProcessStep_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext23 = ((ProcessStep_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ProcessStep_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext24 = ((ProcessStep_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new ProcessStep_TypedDataContext2(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2 refDataContext25 = ((ProcessStep_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext25.GetLocation<string>(refDataContext25.ValueType___Expr25Get, refDataContext25.ValueType___Expr25Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ProcessStep_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext26 = ((ProcessStep_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new ProcessStep_TypedDataContext2(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2 refDataContext27 = ((ProcessStep_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext27.GetLocation<bool>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ProcessStep_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext28 = ((ProcessStep_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ProcessStep_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext29 = ((ProcessStep_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ProcessStep_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext30 = ((ProcessStep_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new ProcessStep_TypedDataContext2(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2 refDataContext31 = ((ProcessStep_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext31.GetLocation<bool>(refDataContext31.ValueType___Expr31Get, refDataContext31.ValueType___Expr31Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ProcessStep_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext32 = ((ProcessStep_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ProcessStep_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext33 = ((ProcessStep_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ProcessStep_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext34 = ((ProcessStep_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new ProcessStep_TypedDataContext2(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2 refDataContext35 = ((ProcessStep_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext35.GetLocation<string>(refDataContext35.ValueType___Expr35Get, refDataContext35.ValueType___Expr35Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 36)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ProcessStep_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext36 = ((ProcessStep_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new ProcessStep_TypedDataContext2(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2 refDataContext37 = ((ProcessStep_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext37.GetLocation<bool>(refDataContext37.ValueType___Expr37Get, refDataContext37.ValueType___Expr37Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 38)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ProcessStep_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext38 = ((ProcessStep_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ProcessStep_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext39 = ((ProcessStep_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ProcessStep_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext40 = ((ProcessStep_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new ProcessStep_TypedDataContext2(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2 refDataContext41 = ((ProcessStep_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext41.GetLocation<string>(refDataContext41.ValueType___Expr41Get, refDataContext41.ValueType___Expr41Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 42)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ProcessStep_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext42 = ((ProcessStep_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext42.ValueType___Expr42Get();
            }
            if ((expressionId == 43)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new ProcessStep_TypedDataContext2(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2 refDataContext43 = ((ProcessStep_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext43.GetLocation<bool>(refDataContext43.ValueType___Expr43Get, refDataContext43.ValueType___Expr43Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 44)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ProcessStep_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ProcessStep_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext44 = ((ProcessStep_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext44.ValueType___Expr44Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.Location> locations) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((expressionId == 0)) {
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext0 = new ProcessStep_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                ProcessStep_TypedDataContext2 refDataContext1 = new ProcessStep_TypedDataContext2(locations, true);
                return refDataContext1.GetLocation<string>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set);
            }
            if ((expressionId == 2)) {
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext2 = new ProcessStep_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                ProcessStep_TypedDataContext2 refDataContext3 = new ProcessStep_TypedDataContext2(locations, true);
                return refDataContext3.GetLocation<string>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set);
            }
            if ((expressionId == 4)) {
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext4 = new ProcessStep_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                ProcessStep_TypedDataContext2 refDataContext5 = new ProcessStep_TypedDataContext2(locations, true);
                return refDataContext5.GetLocation<string>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set);
            }
            if ((expressionId == 6)) {
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext6 = new ProcessStep_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                ProcessStep_TypedDataContext2 refDataContext7 = new ProcessStep_TypedDataContext2(locations, true);
                return refDataContext7.GetLocation<bool>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set);
            }
            if ((expressionId == 8)) {
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext8 = new ProcessStep_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext9 = new ProcessStep_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext10 = new ProcessStep_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext11 = new ProcessStep_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                ProcessStep_TypedDataContext2 refDataContext12 = new ProcessStep_TypedDataContext2(locations, true);
                return refDataContext12.GetLocation<string>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set);
            }
            if ((expressionId == 13)) {
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext13 = new ProcessStep_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                ProcessStep_TypedDataContext2 refDataContext14 = new ProcessStep_TypedDataContext2(locations, true);
                return refDataContext14.GetLocation<bool>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set);
            }
            if ((expressionId == 15)) {
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext15 = new ProcessStep_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext16 = new ProcessStep_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext17 = new ProcessStep_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                ProcessStep_TypedDataContext2 refDataContext18 = new ProcessStep_TypedDataContext2(locations, true);
                return refDataContext18.GetLocation<bool>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set);
            }
            if ((expressionId == 19)) {
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext19 = new ProcessStep_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                ProcessStep_TypedDataContext2 refDataContext20 = new ProcessStep_TypedDataContext2(locations, true);
                return refDataContext20.GetLocation<bool>(refDataContext20.ValueType___Expr20Get, refDataContext20.ValueType___Expr20Set);
            }
            if ((expressionId == 21)) {
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext21 = new ProcessStep_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext22 = new ProcessStep_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext23 = new ProcessStep_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext24 = new ProcessStep_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                ProcessStep_TypedDataContext2 refDataContext25 = new ProcessStep_TypedDataContext2(locations, true);
                return refDataContext25.GetLocation<string>(refDataContext25.ValueType___Expr25Get, refDataContext25.ValueType___Expr25Set);
            }
            if ((expressionId == 26)) {
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext26 = new ProcessStep_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                ProcessStep_TypedDataContext2 refDataContext27 = new ProcessStep_TypedDataContext2(locations, true);
                return refDataContext27.GetLocation<bool>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set);
            }
            if ((expressionId == 28)) {
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext28 = new ProcessStep_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext29 = new ProcessStep_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext30 = new ProcessStep_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                ProcessStep_TypedDataContext2 refDataContext31 = new ProcessStep_TypedDataContext2(locations, true);
                return refDataContext31.GetLocation<bool>(refDataContext31.ValueType___Expr31Get, refDataContext31.ValueType___Expr31Set);
            }
            if ((expressionId == 32)) {
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext32 = new ProcessStep_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext33 = new ProcessStep_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext34 = new ProcessStep_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                ProcessStep_TypedDataContext2 refDataContext35 = new ProcessStep_TypedDataContext2(locations, true);
                return refDataContext35.GetLocation<string>(refDataContext35.ValueType___Expr35Get, refDataContext35.ValueType___Expr35Set);
            }
            if ((expressionId == 36)) {
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext36 = new ProcessStep_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                ProcessStep_TypedDataContext2 refDataContext37 = new ProcessStep_TypedDataContext2(locations, true);
                return refDataContext37.GetLocation<bool>(refDataContext37.ValueType___Expr37Get, refDataContext37.ValueType___Expr37Set);
            }
            if ((expressionId == 38)) {
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext38 = new ProcessStep_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext39 = new ProcessStep_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext40 = new ProcessStep_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                ProcessStep_TypedDataContext2 refDataContext41 = new ProcessStep_TypedDataContext2(locations, true);
                return refDataContext41.GetLocation<string>(refDataContext41.ValueType___Expr41Get, refDataContext41.ValueType___Expr41Set);
            }
            if ((expressionId == 42)) {
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext42 = new ProcessStep_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext42.ValueType___Expr42Get();
            }
            if ((expressionId == 43)) {
                ProcessStep_TypedDataContext2 refDataContext43 = new ProcessStep_TypedDataContext2(locations, true);
                return refDataContext43.GetLocation<bool>(refDataContext43.ValueType___Expr43Get, refDataContext43.ValueType___Expr43Set);
            }
            if ((expressionId == 44)) {
                ProcessStep_TypedDataContext2_ForReadOnly valDataContext44 = new ProcessStep_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext44.ValueType___Expr44Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "stepId") 
                        && (ProcessStep_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "_stepId") 
                        && (ProcessStep_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "stepDescription") 
                        && (ProcessStep_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "_stepDescription") 
                        && (ProcessStep_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "stepInstructions") 
                        && (ProcessStep_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "_stepInstructions") 
                        && (ProcessStep_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "String.Format(\"\\r\\n\\r\\n-----------------\\r\\nStep id: {0}\", stepId)") 
                        && (ProcessStep_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "_doesPowershellAutomationExist") 
                        && (ProcessStep_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "_stepId") 
                        && (ProcessStep_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "_doesPowershellAutomationExist") 
                        && (ProcessStep_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "String.Format(\"\\r\\n---Step description:\\r\\n{0}\\r\\n\\r\\nExecute step? (y/n)\", stepD" +
                            "escription)") 
                        && (ProcessStep_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Console.ReadKey().Key.ToString()") 
                        && (ProcessStep_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "_isExecuteStepAnswer") 
                        && (ProcessStep_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "_isExecuteStepAnswer == \"Y\"") 
                        && (ProcessStep_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "_isExecuteStep") 
                        && (ProcessStep_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "_isExecuteStep") 
                        && (ProcessStep_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "String.Format(\"{0}.ps1\", _stepId)") 
                        && (ProcessStep_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"\\r\\n\\r\\nPowershell automation step complete\"") 
                        && (ProcessStep_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "_isStepComplete") 
                        && (ProcessStep_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!_isStepComplete") 
                        && (ProcessStep_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "_doesDotNetAutomationExist") 
                        && (ProcessStep_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "_stepId") 
                        && (ProcessStep_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "_doesDotNetAutomationExist") 
                        && (ProcessStep_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "String.Format(\"\\r\\n---Step description:\\r\\n{0}\\r\\n\\r\\nExecute step? (y/n)\", stepD" +
                            "escription)") 
                        && (ProcessStep_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Console.ReadKey().Key.ToString()") 
                        && (ProcessStep_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "_isExecuteStepAnswer") 
                        && (ProcessStep_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "_isExecuteStepAnswer == \"Y\"") 
                        && (ProcessStep_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "_isExecuteStep") 
                        && (ProcessStep_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "_isExecuteStep") 
                        && (ProcessStep_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "String.Format(\"{0}.dll\", _stepId)") 
                        && (ProcessStep_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"\\r\\n\\r\\nDotNet automation step complete\"") 
                        && (ProcessStep_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "_isStepComplete") 
                        && (ProcessStep_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!_isStepComplete") 
                        && (ProcessStep_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "String.Format(\"\\r\\n---Step description:\\r\\n{0}\\r\\n\\r\\nExecute step? (y/n)\", stepD" +
                            "escription)") 
                        && (ProcessStep_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Console.ReadKey().Key.ToString()") 
                        && (ProcessStep_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 34;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "_isExecuteStepAnswer") 
                        && (ProcessStep_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 35;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "_isExecuteStepAnswer == \"Y\"") 
                        && (ProcessStep_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 36;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "_isExecuteStep") 
                        && (ProcessStep_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 37;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "_isExecuteStep") 
                        && (ProcessStep_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 38;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "String.Format(\"\\r\\n\\r\\n---Step instructions:\\r\\n{0}\\r\\n\\r\\nIs step complete? (y/n" +
                            ")\", stepInstructions)") 
                        && (ProcessStep_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 39;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Console.ReadKey().Key.ToString()") 
                        && (ProcessStep_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 40;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "_isStepCompleteAnswer") 
                        && (ProcessStep_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 41;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "_isStepCompleteAnswer == \"Y\"") 
                        && (ProcessStep_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 42;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "_isStepComplete") 
                        && (ProcessStep_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 43;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!_isStepComplete") 
                        && (ProcessStep_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 44;
                return true;
            }
            expressionId = -1;
            return false;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Collections.Generic.IList<string> GetRequiredLocations(int expressionId) {
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Linq.Expressions.Expression GetExpressionTreeForExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) {
            if ((expressionId == 0)) {
                return new ProcessStep_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new ProcessStep_TypedDataContext2(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new ProcessStep_TypedDataContext2_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new ProcessStep_TypedDataContext2(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new ProcessStep_TypedDataContext2_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new ProcessStep_TypedDataContext2(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new ProcessStep_TypedDataContext2_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new ProcessStep_TypedDataContext2(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new ProcessStep_TypedDataContext2_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new ProcessStep_TypedDataContext2_ForReadOnly(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new ProcessStep_TypedDataContext2_ForReadOnly(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new ProcessStep_TypedDataContext2_ForReadOnly(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new ProcessStep_TypedDataContext2(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new ProcessStep_TypedDataContext2_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new ProcessStep_TypedDataContext2(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new ProcessStep_TypedDataContext2_ForReadOnly(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new ProcessStep_TypedDataContext2_ForReadOnly(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new ProcessStep_TypedDataContext2_ForReadOnly(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new ProcessStep_TypedDataContext2(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new ProcessStep_TypedDataContext2_ForReadOnly(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new ProcessStep_TypedDataContext2(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new ProcessStep_TypedDataContext2_ForReadOnly(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new ProcessStep_TypedDataContext2_ForReadOnly(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new ProcessStep_TypedDataContext2_ForReadOnly(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new ProcessStep_TypedDataContext2_ForReadOnly(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new ProcessStep_TypedDataContext2(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new ProcessStep_TypedDataContext2_ForReadOnly(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new ProcessStep_TypedDataContext2(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new ProcessStep_TypedDataContext2_ForReadOnly(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new ProcessStep_TypedDataContext2_ForReadOnly(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new ProcessStep_TypedDataContext2_ForReadOnly(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new ProcessStep_TypedDataContext2(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new ProcessStep_TypedDataContext2_ForReadOnly(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new ProcessStep_TypedDataContext2_ForReadOnly(locationReferences).@__Expr33GetTree();
            }
            if ((expressionId == 34)) {
                return new ProcessStep_TypedDataContext2_ForReadOnly(locationReferences).@__Expr34GetTree();
            }
            if ((expressionId == 35)) {
                return new ProcessStep_TypedDataContext2(locationReferences).@__Expr35GetTree();
            }
            if ((expressionId == 36)) {
                return new ProcessStep_TypedDataContext2_ForReadOnly(locationReferences).@__Expr36GetTree();
            }
            if ((expressionId == 37)) {
                return new ProcessStep_TypedDataContext2(locationReferences).@__Expr37GetTree();
            }
            if ((expressionId == 38)) {
                return new ProcessStep_TypedDataContext2_ForReadOnly(locationReferences).@__Expr38GetTree();
            }
            if ((expressionId == 39)) {
                return new ProcessStep_TypedDataContext2_ForReadOnly(locationReferences).@__Expr39GetTree();
            }
            if ((expressionId == 40)) {
                return new ProcessStep_TypedDataContext2_ForReadOnly(locationReferences).@__Expr40GetTree();
            }
            if ((expressionId == 41)) {
                return new ProcessStep_TypedDataContext2(locationReferences).@__Expr41GetTree();
            }
            if ((expressionId == 42)) {
                return new ProcessStep_TypedDataContext2_ForReadOnly(locationReferences).@__Expr42GetTree();
            }
            if ((expressionId == 43)) {
                return new ProcessStep_TypedDataContext2(locationReferences).@__Expr43GetTree();
            }
            if ((expressionId == 44)) {
                return new ProcessStep_TypedDataContext2_ForReadOnly(locationReferences).@__Expr44GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ProcessStep_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ProcessStep_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ProcessStep_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ProcessStep_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ProcessStep_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ProcessStep_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ProcessStep_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ProcessStep_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ProcessStep_TypedDataContext1 : ProcessStep_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ProcessStep_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ProcessStep_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ProcessStep_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string stepInstructions {
                get {
                    return ((string)(this.GetVariableValue((0 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((0 + locationsOffset), value);
                }
            }
            
            protected string stepDescription {
                get {
                    return ((string)(this.GetVariableValue((1 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((1 + locationsOffset), value);
                }
            }
            
            protected string stepId {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((2 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 0)].Name != "stepInstructions") 
                            || (locationReferences[(offset + 0)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "stepDescription") 
                            || (locationReferences[(offset + 1)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "stepId") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                return ProcessStep_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ProcessStep_TypedDataContext1_ForReadOnly : ProcessStep_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ProcessStep_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ProcessStep_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ProcessStep_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string stepInstructions {
                get {
                    return ((string)(this.GetVariableValue((0 + locationsOffset))));
                }
            }
            
            protected string stepDescription {
                get {
                    return ((string)(this.GetVariableValue((1 + locationsOffset))));
                }
            }
            
            protected string stepId {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 0)].Name != "stepInstructions") 
                            || (locationReferences[(offset + 0)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "stepDescription") 
                            || (locationReferences[(offset + 1)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "stepId") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                return ProcessStep_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ProcessStep_TypedDataContext2 : ProcessStep_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool _isExecuteStep;
            
            protected bool _isStepComplete;
            
            protected bool _doesPowershellAutomationExist;
            
            protected bool _doesDotNetAutomationExist;
            
            public ProcessStep_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ProcessStep_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ProcessStep_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string _stepId {
                get {
                    return ((string)(this.GetVariableValue((3 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((3 + locationsOffset), value);
                }
            }
            
            protected string _stepDescription {
                get {
                    return ((string)(this.GetVariableValue((4 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((4 + locationsOffset), value);
                }
            }
            
            protected string _stepInstructions {
                get {
                    return ((string)(this.GetVariableValue((5 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((5 + locationsOffset), value);
                }
            }
            
            protected string _isExecuteStepAnswer {
                get {
                    return ((string)(this.GetVariableValue((7 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((7 + locationsOffset), value);
                }
            }
            
            protected string _isStepCompleteAnswer {
                get {
                    return ((string)(this.GetVariableValue((9 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((9 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 60 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          _stepId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr1Get() {
                
                #line 60 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
          _stepId;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr1Set(string value) {
                
                #line 60 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                
          _stepId = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr1Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr1Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 72 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          _stepDescription;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr3Get() {
                
                #line 72 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
          _stepDescription;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr3Set(string value) {
                
                #line 72 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                
          _stepDescription = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr3Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr3Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 84 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          _stepInstructions;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr5Get() {
                
                #line 84 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
          _stepInstructions;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr5Set(string value) {
                
                #line 84 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                
          _stepInstructions = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr5Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr5Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 101 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
          _doesPowershellAutomationExist;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr7Get() {
                
                #line 101 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
          _doesPowershellAutomationExist;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr7Set(bool value) {
                
                #line 101 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                
          _doesPowershellAutomationExist = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr7Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr7Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 130 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                  _isExecuteStepAnswer;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr12Get() {
                
                #line 130 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
                  _isExecuteStepAnswer;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr12Set(string value) {
                
                #line 130 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                
                  _isExecuteStepAnswer = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr12Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr12Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 142 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  _isExecuteStep;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr14Get() {
                
                #line 142 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
                  _isExecuteStep;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr14Set(bool value) {
                
                #line 142 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                
                  _isExecuteStep = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr14Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr14Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 174 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        _isStepComplete;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr18Get() {
                
                #line 174 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
                        _isStepComplete;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr18Set(bool value) {
                
                #line 174 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                
                        _isStepComplete = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr18Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr18Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 192 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                _doesDotNetAutomationExist;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr20Get() {
                
                #line 192 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
                _doesDotNetAutomationExist;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr20Set(bool value) {
                
                #line 192 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                
                _doesDotNetAutomationExist = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr20Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr20Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 221 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                        _isExecuteStepAnswer;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr25Get() {
                
                #line 221 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
                        _isExecuteStepAnswer;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr25Set(string value) {
                
                #line 221 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                
                        _isExecuteStepAnswer = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr25Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr25Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 233 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        _isExecuteStep;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr27Get() {
                
                #line 233 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
                        _isExecuteStep;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr27Set(bool value) {
                
                #line 233 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                
                        _isExecuteStep = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr27Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr27Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 265 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              _isStepComplete;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr31Get() {
                
                #line 265 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
                              _isStepComplete;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr31Set(bool value) {
                
                #line 265 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                
                              _isStepComplete = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr31Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr31Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr35GetTree() {
                
                #line 292 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                        _isExecuteStepAnswer;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr35Get() {
                
                #line 292 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
                        _isExecuteStepAnswer;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr35Get() {
                this.GetValueTypeValues();
                return this.@__Expr35Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr35Set(string value) {
                
                #line 292 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                
                        _isExecuteStepAnswer = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr35Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr35Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr37GetTree() {
                
                #line 304 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        _isExecuteStep;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr37Get() {
                
                #line 304 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
                        _isExecuteStep;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr37Get() {
                this.GetValueTypeValues();
                return this.@__Expr37Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr37Set(bool value) {
                
                #line 304 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                
                        _isExecuteStep = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr37Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr37Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr41GetTree() {
                
                #line 329 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              _isStepCompleteAnswer;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr41Get() {
                
                #line 329 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
                              _isStepCompleteAnswer;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr41Get() {
                this.GetValueTypeValues();
                return this.@__Expr41Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr41Set(string value) {
                
                #line 329 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                
                              _isStepCompleteAnswer = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr41Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr41Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr43GetTree() {
                
                #line 341 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              _isStepComplete;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr43Get() {
                
                #line 341 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
                              _isStepComplete;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr43Get() {
                this.GetValueTypeValues();
                return this.@__Expr43Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr43Set(bool value) {
                
                #line 341 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                
                              _isStepComplete = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr43Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr43Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this._isExecuteStep = ((bool)(this.GetVariableValue((6 + locationsOffset))));
                this._isStepComplete = ((bool)(this.GetVariableValue((8 + locationsOffset))));
                this._doesPowershellAutomationExist = ((bool)(this.GetVariableValue((10 + locationsOffset))));
                this._doesDotNetAutomationExist = ((bool)(this.GetVariableValue((11 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((6 + locationsOffset), this._isExecuteStep);
                this.SetVariableValue((8 + locationsOffset), this._isStepComplete);
                this.SetVariableValue((10 + locationsOffset), this._doesPowershellAutomationExist);
                this.SetVariableValue((11 + locationsOffset), this._doesDotNetAutomationExist);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 12))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 12);
                }
                expectedLocationsCount = 12;
                if (((locationReferences[(offset + 3)].Name != "_stepId") 
                            || (locationReferences[(offset + 3)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "_stepDescription") 
                            || (locationReferences[(offset + 4)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "_stepInstructions") 
                            || (locationReferences[(offset + 5)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "_isExecuteStepAnswer") 
                            || (locationReferences[(offset + 7)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "_isStepCompleteAnswer") 
                            || (locationReferences[(offset + 9)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "_isExecuteStep") 
                            || (locationReferences[(offset + 6)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "_isStepComplete") 
                            || (locationReferences[(offset + 8)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "_doesPowershellAutomationExist") 
                            || (locationReferences[(offset + 10)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "_doesDotNetAutomationExist") 
                            || (locationReferences[(offset + 11)].Type != typeof(bool)))) {
                    return false;
                }
                return ProcessStep_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ProcessStep_TypedDataContext2_ForReadOnly : ProcessStep_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool _isExecuteStep;
            
            protected bool _isStepComplete;
            
            protected bool _doesPowershellAutomationExist;
            
            protected bool _doesDotNetAutomationExist;
            
            public ProcessStep_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ProcessStep_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ProcessStep_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string _stepId {
                get {
                    return ((string)(this.GetVariableValue((3 + locationsOffset))));
                }
            }
            
            protected string _stepDescription {
                get {
                    return ((string)(this.GetVariableValue((4 + locationsOffset))));
                }
            }
            
            protected string _stepInstructions {
                get {
                    return ((string)(this.GetVariableValue((5 + locationsOffset))));
                }
            }
            
            protected string _isExecuteStepAnswer {
                get {
                    return ((string)(this.GetVariableValue((7 + locationsOffset))));
                }
            }
            
            protected string _isStepCompleteAnswer {
                get {
                    return ((string)(this.GetVariableValue((9 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 65 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          stepId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr0Get() {
                
                #line 65 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
          stepId;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 77 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          stepDescription;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr2Get() {
                
                #line 77 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
          stepDescription;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 89 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          stepInstructions;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr4Get() {
                
                #line 89 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
          stepInstructions;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 95 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
        String.Format("\r\n\r\n-----------------\r\nStep id: {0}", stepId);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr6Get() {
                
                #line 95 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
        String.Format("\r\n\r\n-----------------\r\nStep id: {0}", stepId);
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 106 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          _stepId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr8Get() {
                
                #line 106 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
          _stepId;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 113 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
          _doesPowershellAutomationExist;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr9Get() {
                
                #line 113 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
          _doesPowershellAutomationExist;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 124 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                String.Format("\r\n---Step description:\r\n{0}\r\n\r\nExecute step? (y/n)", stepDescription);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr10Get() {
                
                #line 124 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
                String.Format("\r\n---Step description:\r\n{0}\r\n\r\nExecute step? (y/n)", stepDescription);
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 135 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                  Console.ReadKey().Key.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr11Get() {
                
                #line 135 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
                  Console.ReadKey().Key.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 147 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  _isExecuteStepAnswer == "Y";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr13Get() {
                
                #line 147 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
                  _isExecuteStepAnswer == "Y";
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 154 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  _isExecuteStep;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr15Get() {
                
                #line 154 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
                  _isExecuteStep;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 162 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                        String.Format("{0}.ps1", _stepId);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr16Get() {
                
                #line 162 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
                        String.Format("{0}.ps1", _stepId);
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 168 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                      "\r\n\r\nPowershell automation step complete";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr17Get() {
                
                #line 168 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
                      "\r\n\r\nPowershell automation step complete";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 119 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
            !_isStepComplete;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr19Get() {
                
                #line 119 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
            !_isStepComplete;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 197 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                _stepId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr21Get() {
                
                #line 197 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
                _stepId;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 204 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                _doesDotNetAutomationExist;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr22Get() {
                
                #line 204 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
                _doesDotNetAutomationExist;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 215 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                      String.Format("\r\n---Step description:\r\n{0}\r\n\r\nExecute step? (y/n)", stepDescription);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr23Get() {
                
                #line 215 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
                      String.Format("\r\n---Step description:\r\n{0}\r\n\r\nExecute step? (y/n)", stepDescription);
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 226 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                        Console.ReadKey().Key.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr24Get() {
                
                #line 226 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
                        Console.ReadKey().Key.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 238 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        _isExecuteStepAnswer == "Y";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr26Get() {
                
                #line 238 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
                        _isExecuteStepAnswer == "Y";
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 245 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        _isExecuteStep;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr28Get() {
                
                #line 245 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
                        _isExecuteStep;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 253 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              String.Format("{0}.dll", _stepId);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr29Get() {
                
                #line 253 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
                              String.Format("{0}.dll", _stepId);
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 259 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                            "\r\n\r\nDotNet automation step complete";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr30Get() {
                
                #line 259 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
                            "\r\n\r\nDotNet automation step complete";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 210 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  !_isStepComplete;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr32Get() {
                
                #line 210 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
                  !_isStepComplete;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr33GetTree() {
                
                #line 286 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                      String.Format("\r\n---Step description:\r\n{0}\r\n\r\nExecute step? (y/n)", stepDescription);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr33Get() {
                
                #line 286 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
                      String.Format("\r\n---Step description:\r\n{0}\r\n\r\nExecute step? (y/n)", stepDescription);
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr34GetTree() {
                
                #line 297 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                        Console.ReadKey().Key.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr34Get() {
                
                #line 297 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
                        Console.ReadKey().Key.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr34Get() {
                this.GetValueTypeValues();
                return this.@__Expr34Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr36GetTree() {
                
                #line 309 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        _isExecuteStepAnswer == "Y";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr36Get() {
                
                #line 309 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
                        _isExecuteStepAnswer == "Y";
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr36Get() {
                this.GetValueTypeValues();
                return this.@__Expr36Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr38GetTree() {
                
                #line 316 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        _isExecuteStep;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr38Get() {
                
                #line 316 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
                        _isExecuteStep;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr38Get() {
                this.GetValueTypeValues();
                return this.@__Expr38Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr39GetTree() {
                
                #line 323 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                            String.Format("\r\n\r\n---Step instructions:\r\n{0}\r\n\r\nIs step complete? (y/n)", stepInstructions);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr39Get() {
                
                #line 323 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
                            String.Format("\r\n\r\n---Step instructions:\r\n{0}\r\n\r\nIs step complete? (y/n)", stepInstructions);
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr39Get() {
                this.GetValueTypeValues();
                return this.@__Expr39Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr40GetTree() {
                
                #line 334 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              Console.ReadKey().Key.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr40Get() {
                
                #line 334 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
                              Console.ReadKey().Key.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr40Get() {
                this.GetValueTypeValues();
                return this.@__Expr40Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr42GetTree() {
                
                #line 346 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              _isStepCompleteAnswer == "Y";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr42Get() {
                
                #line 346 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
                              _isStepCompleteAnswer == "Y";
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr42Get() {
                this.GetValueTypeValues();
                return this.@__Expr42Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr44GetTree() {
                
                #line 281 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  !_isStepComplete;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr44Get() {
                
                #line 281 "C:\DEV\DEVELOPMENT\SANDBOX\MMAPMAN\MMAPMANAGER\MMAPMANAGER.CONSOLE\ACTIVITY\PROCESSSTEP.XAML"
                return 
                  !_isStepComplete;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr44Get() {
                this.GetValueTypeValues();
                return this.@__Expr44Get();
            }
            
            protected override void GetValueTypeValues() {
                this._isExecuteStep = ((bool)(this.GetVariableValue((6 + locationsOffset))));
                this._isStepComplete = ((bool)(this.GetVariableValue((8 + locationsOffset))));
                this._doesPowershellAutomationExist = ((bool)(this.GetVariableValue((10 + locationsOffset))));
                this._doesDotNetAutomationExist = ((bool)(this.GetVariableValue((11 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 12))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 12);
                }
                expectedLocationsCount = 12;
                if (((locationReferences[(offset + 3)].Name != "_stepId") 
                            || (locationReferences[(offset + 3)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "_stepDescription") 
                            || (locationReferences[(offset + 4)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "_stepInstructions") 
                            || (locationReferences[(offset + 5)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "_isExecuteStepAnswer") 
                            || (locationReferences[(offset + 7)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "_isStepCompleteAnswer") 
                            || (locationReferences[(offset + 9)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "_isExecuteStep") 
                            || (locationReferences[(offset + 6)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "_isStepComplete") 
                            || (locationReferences[(offset + 8)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "_doesPowershellAutomationExist") 
                            || (locationReferences[(offset + 10)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "_doesDotNetAutomationExist") 
                            || (locationReferences[(offset + 11)].Type != typeof(bool)))) {
                    return false;
                }
                return ProcessStep_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
