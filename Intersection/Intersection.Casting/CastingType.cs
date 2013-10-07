using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Intersection.Intersection.Casting
{
    public enum CastingType { 
        SandCasting,
        ShellMoulding,
        GravityMouldCasting,
        SlushCasting,
        CentrifugalCasting,
        InvestmentCasting,
        LostFoamCasting,
        CeramicMouldCasting,
        ElectrochemicalMachining,
        ElectrochemicalGrinding,
        ElectrochemicalPolishing,
        //additional casting from db2
        PlasterMoldCasting,
        ColdDieCasting,
        HotDieCasting,
        PowderMetallurgy,
        InjectionMolding,
        CoInjection,
        ReactionInjectionMolding,
        TransferMolding

    }

    public static class CastingTypeHelper
    {
        public static string GetCastingTypeName(CastingType type){
            
            switch(type){
                case CastingType.SandCasting: return "Sand Casting";
                case CastingType.ShellMoulding: return "Shell Moulding";
                case CastingType.GravityMouldCasting: return "Gravity Mould Casting";
                case CastingType.SlushCasting: return "Slush Casting";
                case CastingType.CentrifugalCasting: return "Centrifugal Casting";
                case CastingType.InvestmentCasting: return "Investment Casting";
                case CastingType.LostFoamCasting: return "Lost Foam Casting";
                case CastingType.CeramicMouldCasting: return "Ceramic Mould Casting";
                case CastingType.ElectrochemicalMachining: return "Electrochemical Machining";
                case CastingType.ElectrochemicalGrinding: return "Electrochemical Grinding";
                case CastingType.ElectrochemicalPolishing: return "Electrochemical Polishing";
                case CastingType.PlasterMoldCasting: return "Plaster Mold Casting";
                case CastingType.ColdDieCasting: return "Cold Die Casting";
                case CastingType.HotDieCasting: return "Hot Die Casting";
                case CastingType.PowderMetallurgy: return "Powder Metallurgy";
                case CastingType.InjectionMolding: return "Injection Molding";
                case CastingType.CoInjection: return "CoInjection";
                case CastingType.ReactionInjectionMolding: return "Reaction Injection Molding";
                case CastingType.TransferMolding: return "Transfer Molding";
        
                default: return string.Empty;
            }

        }
    }
}
