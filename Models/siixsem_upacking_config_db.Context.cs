﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace upacking_bajas.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class siixsem_upacking_data_dbEntities1 : DbContext
    {
        public siixsem_upacking_data_dbEntities1()
            : base("name=siixsem_upacking_data_dbEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<siixsem_010B_BUL_PCA_ABC_gb> siixsem_010B_BUL_PCA_ABC_gb { get; set; }
        public virtual DbSet<siixsem_010B_BUL_PCA_ABC_pck> siixsem_010B_BUL_PCA_ABC_pck { get; set; }
        public virtual DbSet<siixsem_010B_BUL_PCA_D_gb> siixsem_010B_BUL_PCA_D_gb { get; set; }
        public virtual DbSet<siixsem_010B_BUL_PCA_D_pck> siixsem_010B_BUL_PCA_D_pck { get; set; }
        public virtual DbSet<siixsem_010B_BUL_PCA_F_gb> siixsem_010B_BUL_PCA_F_gb { get; set; }
        public virtual DbSet<siixsem_010B_BUL_PCA_F_pck> siixsem_010B_BUL_PCA_F_pck { get; set; }
        public virtual DbSet<siixsem_0517_1_gb> siixsem_0517_1_gb { get; set; }
        public virtual DbSet<siixsem_0517_1_pck> siixsem_0517_1_pck { get; set; }
        public virtual DbSet<siixsem_0517_gb> siixsem_0517_gb { get; set; }
        public virtual DbSet<siixsem_0517_pck> siixsem_0517_pck { get; set; }
        public virtual DbSet<siixsem_100DAutoSlide_920BDeckLamp_gb> siixsem_100DAutoSlide_920BDeckLamp_gb { get; set; }
        public virtual DbSet<siixsem_100DAutoSlide_920BDeckLamp_pck> siixsem_100DAutoSlide_920BDeckLamp_pck { get; set; }
        public virtual DbSet<siixsem_141D_Telltale_309_gb> siixsem_141D_Telltale_309_gb { get; set; }
        public virtual DbSet<siixsem_141D_Telltale_309_pck> siixsem_141D_Telltale_309_pck { get; set; }
        public virtual DbSet<siixsem_141D_Telltale_310_gb> siixsem_141D_Telltale_310_gb { get; set; }
        public virtual DbSet<siixsem_141D_Telltale_310_pck> siixsem_141D_Telltale_310_pck { get; set; }
        public virtual DbSet<siixsem_141D_Telltale_311_gb> siixsem_141D_Telltale_311_gb { get; set; }
        public virtual DbSet<siixsem_141D_Telltale_311_pck> siixsem_141D_Telltale_311_pck { get; set; }
        public virtual DbSet<siixsem_141D_Telltale_312_gb> siixsem_141D_Telltale_312_gb { get; set; }
        public virtual DbSet<siixsem_141D_Telltale_312_pck> siixsem_141D_Telltale_312_pck { get; set; }
        public virtual DbSet<siixsem_145B_gb> siixsem_145B_gb { get; set; }
        public virtual DbSet<siixsem_145B_pck> siixsem_145B_pck { get; set; }
        public virtual DbSet<siixsem_150B_BSM_gb> siixsem_150B_BSM_gb { get; set; }
        public virtual DbSet<siixsem_150B_BSM_pck> siixsem_150B_BSM_pck { get; set; }
        public virtual DbSet<siixsem_150B_LDM_cov> siixsem_150B_LDM_cov { get; set; }
        public virtual DbSet<siixsem_150B_LDM_gb> siixsem_150B_LDM_gb { get; set; }
        public virtual DbSet<siixsem_150B_LDM_pck> siixsem_150B_LDM_pck { get; set; }
        public virtual DbSet<siixsem_177D_EPB_gb> siixsem_177D_EPB_gb { get; set; }
        public virtual DbSet<siixsem_177D_EPB_pck> siixsem_177D_EPB_pck { get; set; }
        public virtual DbSet<siixsem_177D_HPI_571_gb> siixsem_177D_HPI_571_gb { get; set; }
        public virtual DbSet<siixsem_177D_HPI_571_pck> siixsem_177D_HPI_571_pck { get; set; }
        public virtual DbSet<siixsem_177D_HPI_583_gb> siixsem_177D_HPI_583_gb { get; set; }
        public virtual DbSet<siixsem_177D_HPI_583_pck> siixsem_177D_HPI_583_pck { get; set; }
        public virtual DbSet<siixsem_177D_HPI_694_gb> siixsem_177D_HPI_694_gb { get; set; }
        public virtual DbSet<siixsem_177D_HPI_694_pck> siixsem_177D_HPI_694_pck { get; set; }
        public virtual DbSet<siixsem_177D_HPI_695_gb> siixsem_177D_HPI_695_gb { get; set; }
        public virtual DbSet<siixsem_177D_HPI_695_pck> siixsem_177D_HPI_695_pck { get; set; }
        public virtual DbSet<siixsem_177D_MR_89239_gb> siixsem_177D_MR_89239_gb { get; set; }
        public virtual DbSet<siixsem_177D_MR_89239_pck> siixsem_177D_MR_89239_pck { get; set; }
        public virtual DbSet<siixsem_177D_NR_89238_gb> siixsem_177D_NR_89238_gb { get; set; }
        public virtual DbSet<siixsem_177D_NR_89238_pck> siixsem_177D_NR_89238_pck { get; set; }
        public virtual DbSet<siixsem_200D_SMART_LDM_BG_cov> siixsem_200D_SMART_LDM_BG_cov { get; set; }
        public virtual DbSet<siixsem_200D_SMART_LDM_BG_gb> siixsem_200D_SMART_LDM_BG_gb { get; set; }
        public virtual DbSet<siixsem_200D_SMART_LDM_BG_pck> siixsem_200D_SMART_LDM_BG_pck { get; set; }
        public virtual DbSet<siixsem_200D_SMART_LDM_HG_cov> siixsem_200D_SMART_LDM_HG_cov { get; set; }
        public virtual DbSet<siixsem_220D_SMART_LDM_cov> siixsem_220D_SMART_LDM_cov { get; set; }
        public virtual DbSet<siixsem_220D_SMART_LDM_gb> siixsem_220D_SMART_LDM_gb { get; set; }
        public virtual DbSet<siixsem_220D_SMART_LDM_pck> siixsem_220D_SMART_LDM_pck { get; set; }
        public virtual DbSet<siixsem_227B_gb> siixsem_227B_gb { get; set; }
        public virtual DbSet<siixsem_227B_pck> siixsem_227B_pck { get; set; }
        public virtual DbSet<siixsem_227D_HPI_gb> siixsem_227D_HPI_gb { get; set; }
        public virtual DbSet<siixsem_227D_HPI_pck> siixsem_227D_HPI_pck { get; set; }
        public virtual DbSet<siixsem_227D_MR_89241_gb> siixsem_227D_MR_89241_gb { get; set; }
        public virtual DbSet<siixsem_227D_MR_89241_pck> siixsem_227D_MR_89241_pck { get; set; }
        public virtual DbSet<siixsem_227D_NR_89240_gb> siixsem_227D_NR_89240_gb { get; set; }
        public virtual DbSet<siixsem_227D_NR_89240_pck> siixsem_227D_NR_89240_pck { get; set; }
        public virtual DbSet<siixsem_227D_SW_gb> siixsem_227D_SW_gb { get; set; }
        public virtual DbSet<siixsem_227D_SW_pck> siixsem_227D_SW_pck { get; set; }
        public virtual DbSet<siixsem_305B_C_E_gb> siixsem_305B_C_E_gb { get; set; }
        public virtual DbSet<siixsem_305B_C_E_pck> siixsem_305B_C_E_pck { get; set; }
        public virtual DbSet<siixsem_305B_D_F_gb> siixsem_305B_D_F_gb { get; set; }
        public virtual DbSet<siixsem_305B_D_F_pck> siixsem_305B_D_F_pck { get; set; }
        public virtual DbSet<siixsem_305B_LB_LED_A_gb> siixsem_305B_LB_LED_A_gb { get; set; }
        public virtual DbSet<siixsem_305B_LB_LED_A_pck> siixsem_305B_LB_LED_A_pck { get; set; }
        public virtual DbSet<siixsem_311D_DMS_620_gb> siixsem_311D_DMS_620_gb { get; set; }
        public virtual DbSet<siixsem_311D_DMS_620_pck> siixsem_311D_DMS_620_pck { get; set; }
        public virtual DbSet<siixsem_311D_DMS_621_gb> siixsem_311D_DMS_621_gb { get; set; }
        public virtual DbSet<siixsem_311D_DMS_621_pck> siixsem_311D_DMS_621_pck { get; set; }
        public virtual DbSet<siixsem_311D_DMS_622_gb> siixsem_311D_DMS_622_gb { get; set; }
        public virtual DbSet<siixsem_311D_DMS_622_pck> siixsem_311D_DMS_622_pck { get; set; }
        public virtual DbSet<siixsem_360B_BUL_gb> siixsem_360B_BUL_gb { get; set; }
        public virtual DbSet<siixsem_360B_BUL_pck> siixsem_360B_BUL_pck { get; set; }
        public virtual DbSet<siixsem_380D_BG_SMART_LDM_cov> siixsem_380D_BG_SMART_LDM_cov { get; set; }
        public virtual DbSet<siixsem_380D_BG_SMART_LDM_gb> siixsem_380D_BG_SMART_LDM_gb { get; set; }
        public virtual DbSet<siixsem_380D_BG_SMART_LDM_pck> siixsem_380D_BG_SMART_LDM_pck { get; set; }
        public virtual DbSet<siixsem_380D_HG_SMART_LDM_cov> siixsem_380D_HG_SMART_LDM_cov { get; set; }
        public virtual DbSet<siixsem_380D_HG_SMART_LDM_gb> siixsem_380D_HG_SMART_LDM_gb { get; set; }
        public virtual DbSet<siixsem_380D_HG_SMART_LDM_pck> siixsem_380D_HG_SMART_LDM_pck { get; set; }
        public virtual DbSet<siixsem_3S5A_LCM_gb> siixsem_3S5A_LCM_gb { get; set; }
        public virtual DbSet<siixsem_3S5A_LCM_pck> siixsem_3S5A_LCM_pck { get; set; }
        public virtual DbSet<siixsem_3V0A_LCM_cov> siixsem_3V0A_LCM_cov { get; set; }
        public virtual DbSet<siixsem_3V0A_LCM_gb> siixsem_3V0A_LCM_gb { get; set; }
        public virtual DbSet<siixsem_3V0A_LCM_pck> siixsem_3V0A_LCM_pck { get; set; }
        public virtual DbSet<siixsem_3W0A_AB_gb> siixsem_3W0A_AB_gb { get; set; }
        public virtual DbSet<siixsem_3W0A_AB_pck> siixsem_3W0A_AB_pck { get; set; }
        public virtual DbSet<siixsem_3W0A_C_7D_gb> siixsem_3W0A_C_7D_gb { get; set; }
        public virtual DbSet<siixsem_3W0A_C_7D_pck> siixsem_3W0A_C_7D_pck { get; set; }
        public virtual DbSet<siixsem_3W0A_C_gb> siixsem_3W0A_C_gb { get; set; }
        public virtual DbSet<siixsem_3W0A_C_pck> siixsem_3W0A_C_pck { get; set; }
        public virtual DbSet<siixsem_3W0A_D_gb> siixsem_3W0A_D_gb { get; set; }
        public virtual DbSet<siixsem_3W0A_D_pck> siixsem_3W0A_D_pck { get; set; }
        public virtual DbSet<siixsem_3W0A_E_gb> siixsem_3W0A_E_gb { get; set; }
        public virtual DbSet<siixsem_3W0A_E_pck> siixsem_3W0A_E_pck { get; set; }
        public virtual DbSet<siixsem_3W0A_F_gb> siixsem_3W0A_F_gb { get; set; }
        public virtual DbSet<siixsem_3W0A_F_pck> siixsem_3W0A_F_pck { get; set; }
        public virtual DbSet<siixsem_550B_LDM_BG_gb> siixsem_550B_LDM_BG_gb { get; set; }
        public virtual DbSet<siixsem_550B_LDM_BG_pck> siixsem_550B_LDM_BG_pck { get; set; }
        public virtual DbSet<siixsem_561D_4WD_gb> siixsem_561D_4WD_gb { get; set; }
        public virtual DbSet<siixsem_561D_4WD_pck> siixsem_561D_4WD_pck { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_596_gb> siixsem_561D_COMBI_SW_596_gb { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_596_pck> siixsem_561D_COMBI_SW_596_pck { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_597_gb> siixsem_561D_COMBI_SW_597_gb { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_597_pck> siixsem_561D_COMBI_SW_597_pck { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_598_gb> siixsem_561D_COMBI_SW_598_gb { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_598_pck> siixsem_561D_COMBI_SW_598_pck { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_599_gb> siixsem_561D_COMBI_SW_599_gb { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_599_pck> siixsem_561D_COMBI_SW_599_pck { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_600_gb> siixsem_561D_COMBI_SW_600_gb { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_600_pck> siixsem_561D_COMBI_SW_600_pck { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_601_gb> siixsem_561D_COMBI_SW_601_gb { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_601_pck> siixsem_561D_COMBI_SW_601_pck { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_602_gb> siixsem_561D_COMBI_SW_602_gb { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_602_pck> siixsem_561D_COMBI_SW_602_pck { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_603_gb> siixsem_561D_COMBI_SW_603_gb { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_603_pck> siixsem_561D_COMBI_SW_603_pck { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_604_gb> siixsem_561D_COMBI_SW_604_gb { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_604_pck> siixsem_561D_COMBI_SW_604_pck { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_665_gb> siixsem_561D_COMBI_SW_665_gb { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_665_pck> siixsem_561D_COMBI_SW_665_pck { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_666_gb> siixsem_561D_COMBI_SW_666_gb { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_666_pck> siixsem_561D_COMBI_SW_666_pck { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_667_gb> siixsem_561D_COMBI_SW_667_gb { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_667_pck> siixsem_561D_COMBI_SW_667_pck { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_668_gb> siixsem_561D_COMBI_SW_668_gb { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_668_pck> siixsem_561D_COMBI_SW_668_pck { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_669_gb> siixsem_561D_COMBI_SW_669_gb { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_669_pck> siixsem_561D_COMBI_SW_669_pck { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_670_gb> siixsem_561D_COMBI_SW_670_gb { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_670_pck> siixsem_561D_COMBI_SW_670_pck { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_671_gb> siixsem_561D_COMBI_SW_671_gb { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_671_pck> siixsem_561D_COMBI_SW_671_pck { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_672_gb> siixsem_561D_COMBI_SW_672_gb { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_672_pck> siixsem_561D_COMBI_SW_672_pck { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_673_gb> siixsem_561D_COMBI_SW_673_gb { get; set; }
        public virtual DbSet<siixsem_561D_COMBI_SW_673_pck> siixsem_561D_COMBI_SW_673_pck { get; set; }
        public virtual DbSet<siixsem_625B_CHL_LDM_gb> siixsem_625B_CHL_LDM_gb { get; set; }
        public virtual DbSet<siixsem_625B_CHL_LDM_pck> siixsem_625B_CHL_LDM_pck { get; set; }
        public virtual DbSet<siixsem_625B_DRL_LDM_cov> siixsem_625B_DRL_LDM_cov { get; set; }
        public virtual DbSet<siixsem_625B_DRL_LDM_gb> siixsem_625B_DRL_LDM_gb { get; set; }
        public virtual DbSet<siixsem_625B_DRL_LDM_pck> siixsem_625B_DRL_LDM_pck { get; set; }
        public virtual DbSet<siixsem_652_W_FEP_gb> siixsem_652_W_FEP_gb { get; set; }
        public virtual DbSet<siixsem_652_W_FEP_pck> siixsem_652_W_FEP_pck { get; set; }
        public virtual DbSet<siixsem_685B_CHL_HG_C_gb> siixsem_685B_CHL_HG_C_gb { get; set; }
        public virtual DbSet<siixsem_685B_CHL_HG_C_pck> siixsem_685B_CHL_HG_C_pck { get; set; }
        public virtual DbSet<siixsem_780B_CHL_BG_FPC_gb> siixsem_780B_CHL_BG_FPC_gb { get; set; }
        public virtual DbSet<siixsem_780B_CHL_BG_FPC_pck> siixsem_780B_CHL_BG_FPC_pck { get; set; }
        public virtual DbSet<siixsem_780B_CHL_HG_LDM_A_gb> siixsem_780B_CHL_HG_LDM_A_gb { get; set; }
        public virtual DbSet<siixsem_780B_CHL_HG_LDM_A_pck> siixsem_780B_CHL_HG_LDM_A_pck { get; set; }
        public virtual DbSet<siixsem_780B_FLF_LDM_A_gb> siixsem_780B_FLF_LDM_A_gb { get; set; }
        public virtual DbSet<siixsem_780B_FLF_LDM_A_pck> siixsem_780B_FLF_LDM_A_pck { get; set; }
        public virtual DbSet<siixsem_780B_Lamp_ECU_AIR_cov> siixsem_780B_Lamp_ECU_AIR_cov { get; set; }
        public virtual DbSet<siixsem_780B_Lamp_ECU_AIR_gb> siixsem_780B_Lamp_ECU_AIR_gb { get; set; }
        public virtual DbSet<siixsem_780B_Lamp_ECU_AIR_pck> siixsem_780B_Lamp_ECU_AIR_pck { get; set; }
        public virtual DbSet<siixsem_780B_Lamp_ECU_High_cov> siixsem_780B_Lamp_ECU_High_cov { get; set; }
        public virtual DbSet<siixsem_780B_Lamp_ECU_High_gb> siixsem_780B_Lamp_ECU_High_gb { get; set; }
        public virtual DbSet<siixsem_780B_Lamp_ECU_High_pck> siixsem_780B_Lamp_ECU_High_pck { get; set; }
        public virtual DbSet<siixsem_780B_RCL_BG_F_gb> siixsem_780B_RCL_BG_F_gb { get; set; }
        public virtual DbSet<siixsem_780B_RCL_BG_F_pck> siixsem_780B_RCL_BG_F_pck { get; set; }
        public virtual DbSet<siixsem_780B_RCL_HG_C_gb> siixsem_780B_RCL_HG_C_gb { get; set; }
        public virtual DbSet<siixsem_780B_RCL_HG_C_pck> siixsem_780B_RCL_HG_C_pck { get; set; }
        public virtual DbSet<siixsem_780B_SMART_LDM_cov> siixsem_780B_SMART_LDM_cov { get; set; }
        public virtual DbSet<siixsem_780B_SMART_LDM_gb> siixsem_780B_SMART_LDM_gb { get; set; }
        public virtual DbSet<siixsem_780B_SMART_LDM_pck> siixsem_780B_SMART_LDM_pck { get; set; }
        public virtual DbSet<siixsem_780B_TOGGLE_P759_gb> siixsem_780B_TOGGLE_P759_gb { get; set; }
        public virtual DbSet<siixsem_780B_TOGGLE_P759_pck> siixsem_780B_TOGGLE_P759_pck { get; set; }
        public virtual DbSet<siixsem_780B_TOGGLE_P901_gb> siixsem_780B_TOGGLE_P901_gb { get; set; }
        public virtual DbSet<siixsem_780B_TOGGLE_P901_pck> siixsem_780B_TOGGLE_P901_pck { get; set; }
        public virtual DbSet<siixsem_780B_TOGGLE_P902_gb> siixsem_780B_TOGGLE_P902_gb { get; set; }
        public virtual DbSet<siixsem_780B_TOGGLE_P902_pck> siixsem_780B_TOGGLE_P902_pck { get; set; }
        public virtual DbSet<siixsem_780B_TOGGLE_P903_gb> siixsem_780B_TOGGLE_P903_gb { get; set; }
        public virtual DbSet<siixsem_780B_TOGGLE_P903_pck> siixsem_780B_TOGGLE_P903_pck { get; set; }
        public virtual DbSet<siixsem_790B_LIGHT_BAR_gb> siixsem_790B_LIGHT_BAR_gb { get; set; }
        public virtual DbSet<siixsem_790B_LIGHT_BAR_pck> siixsem_790B_LIGHT_BAR_pck { get; set; }
        public virtual DbSet<siixsem_790B_SMART_LDM_gb> siixsem_790B_SMART_LDM_gb { get; set; }
        public virtual DbSet<siixsem_790B_SMART_LDM_pck> siixsem_790B_SMART_LDM_pck { get; set; }
        public virtual DbSet<siixsem_890B_BG_LDM_cov> siixsem_890B_BG_LDM_cov { get; set; }
        public virtual DbSet<siixsem_890B_BG_LDM_gb> siixsem_890B_BG_LDM_gb { get; set; }
        public virtual DbSet<siixsem_890B_BG_LDM_pck> siixsem_890B_BG_LDM_pck { get; set; }
        public virtual DbSet<siixsem_890B_Smart_LDM_gb> siixsem_890B_Smart_LDM_gb { get; set; }
        public virtual DbSet<siixsem_890B_Smart_LDM_pck> siixsem_890B_Smart_LDM_pck { get; set; }
        public virtual DbSet<siixsem_910B_SMART_LDM_cov> siixsem_910B_SMART_LDM_cov { get; set; }
        public virtual DbSet<siixsem_910B_SMART_LDM_gb> siixsem_910B_SMART_LDM_gb { get; set; }
        public virtual DbSet<siixsem_910B_SMART_LDM_pck> siixsem_910B_SMART_LDM_pck { get; set; }
        public virtual DbSet<siixsem_920B_DL_HB_MOTHERBOARD_A_gb> siixsem_920B_DL_HB_MOTHERBOARD_A_gb { get; set; }
        public virtual DbSet<siixsem_920B_DL_HB_MOTHERBOARD_A_pck> siixsem_920B_DL_HB_MOTHERBOARD_A_pck { get; set; }
        public virtual DbSet<siixsem_920B_DL_HB_SECONDARY_LDM_D_gb> siixsem_920B_DL_HB_SECONDARY_LDM_D_gb { get; set; }
        public virtual DbSet<siixsem_920B_DL_HB_SECONDARY_LDM_D_pck> siixsem_920B_DL_HB_SECONDARY_LDM_D_pck { get; set; }
        public virtual DbSet<siixsem_920B_M_SMART_LDM_cov> siixsem_920B_M_SMART_LDM_cov { get; set; }
        public virtual DbSet<siixsem_920B_WRSM_gb> siixsem_920B_WRSM_gb { get; set; }
        public virtual DbSet<siixsem_920B_WRSM_pck> siixsem_920B_WRSM_pck { get; set; }
        public virtual DbSet<siixsem_922B_910B_MR_89012_gb> siixsem_922B_910B_MR_89012_gb { get; set; }
        public virtual DbSet<siixsem_922B_910B_MR_89012_pck> siixsem_922B_910B_MR_89012_pck { get; set; }
        public virtual DbSet<siixsem_CH2_LCM_cov> siixsem_CH2_LCM_cov { get; set; }
        public virtual DbSet<siixsem_CH2_LCM_gb> siixsem_CH2_LCM_gb { get; set; }
        public virtual DbSet<siixsem_CH2_LCM_pck> siixsem_CH2_LCM_pck { get; set; }
        public virtual DbSet<siixsem_current_box_model> siixsem_current_box_model { get; set; }
        public virtual DbSet<siixsem_FCA_WL_RGB_gb> siixsem_FCA_WL_RGB_gb { get; set; }
        public virtual DbSet<siixsem_FCA_WL_RGB_pck> siixsem_FCA_WL_RGB_pck { get; set; }
        public virtual DbSet<siixsem_H61P_DRL_gb> siixsem_H61P_DRL_gb { get; set; }
        public virtual DbSet<siixsem_H61P_DRL_pck> siixsem_H61P_DRL_pck { get; set; }
        public virtual DbSet<siixsem_H61P_LDM_gb> siixsem_H61P_LDM_gb { get; set; }
        public virtual DbSet<siixsem_H61P_LDM_pck> siixsem_H61P_LDM_pck { get; set; }
        public virtual DbSet<siixsem_L02D_HL_B_gb> siixsem_L02D_HL_B_gb { get; set; }
        public virtual DbSet<siixsem_L02D_HL_B_pck> siixsem_L02D_HL_B_pck { get; set; }
        public virtual DbSet<siixsem_L02D_Lo_Hi_LDM_gb> siixsem_L02D_Lo_Hi_LDM_gb { get; set; }
        public virtual DbSet<siixsem_L02D_Lo_Hi_LDM_pck> siixsem_L02D_Lo_Hi_LDM_pck { get; set; }
        public virtual DbSet<siixsem_L42N_HB_LED_gb> siixsem_L42N_HB_LED_gb { get; set; }
        public virtual DbSet<siixsem_L42N_HB_LED_pck> siixsem_L42N_HB_LED_pck { get; set; }
        public virtual DbSet<siixsem_L42N_LDM_LB_cov> siixsem_L42N_LDM_LB_cov { get; set; }
        public virtual DbSet<siixsem_L42N_LDM_LB_gb> siixsem_L42N_LDM_LB_gb { get; set; }
        public virtual DbSet<siixsem_L42N_LDM_LB_pck> siixsem_L42N_LDM_LB_pck { get; set; }
        public virtual DbSet<siixsem_L42N_SM_gb> siixsem_L42N_SM_gb { get; set; }
        public virtual DbSet<siixsem_L42N_SM_pck> siixsem_L42N_SM_pck { get; set; }
        public virtual DbSet<siixsem_L42P_CHL_A_gb> siixsem_L42P_CHL_A_gb { get; set; }
        public virtual DbSet<siixsem_L42P_CHL_A_pck> siixsem_L42P_CHL_A_pck { get; set; }
        public virtual DbSet<siixsem_Main_PCB_gb> siixsem_Main_PCB_gb { get; set; }
        public virtual DbSet<siixsem_Main_PCB_pck> siixsem_Main_PCB_pck { get; set; }
        public virtual DbSet<siixsem_NLog_t> siixsem_NLog_t { get; set; }
        public virtual DbSet<siixsem_P13C_RCL_Led_Assy_A_gb> siixsem_P13C_RCL_Led_Assy_A_gb { get; set; }
        public virtual DbSet<siixsem_P13C_RCL_Led_Assy_A_pck> siixsem_P13C_RCL_Led_Assy_A_pck { get; set; }
        public virtual DbSet<siixsem_P13C_RCL_Led_Sub_Assy_B1_gb> siixsem_P13C_RCL_Led_Sub_Assy_B1_gb { get; set; }
        public virtual DbSet<siixsem_P13C_RCL_Led_Sub_Assy_B1_pck> siixsem_P13C_RCL_Led_Sub_Assy_B1_pck { get; set; }
        public virtual DbSet<siixsem_P32R_LDM_gb> siixsem_P32R_LDM_gb { get; set; }
        public virtual DbSet<siixsem_P32R_LDM_pck> siixsem_P32R_LDM_pck { get; set; }
        public virtual DbSet<siixsem_P33A_BUL_PCA_A_gb> siixsem_P33A_BUL_PCA_A_gb { get; set; }
        public virtual DbSet<siixsem_P33A_BUL_PCA_A_pck> siixsem_P33A_BUL_PCA_A_pck { get; set; }
        public virtual DbSet<siixsem_P33A_RCL_PCA_C_gb> siixsem_P33A_RCL_PCA_C_gb { get; set; }
        public virtual DbSet<siixsem_P33A_RCL_PCA_C_pck> siixsem_P33A_RCL_PCA_C_pck { get; set; }
        public virtual DbSet<siixsem_P42J_M_LDM_SAE_gb> siixsem_P42J_M_LDM_SAE_gb { get; set; }
        public virtual DbSet<siixsem_P42J_M_LDM_SAE_pck> siixsem_P42J_M_LDM_SAE_pck { get; set; }
        public virtual DbSet<siixsem_P42M_CHL_LB_HB_KIT_gb> siixsem_P42M_CHL_LB_HB_KIT_gb { get; set; }
        public virtual DbSet<siixsem_P42M_CHL_LB_HB_KIT_pck> siixsem_P42M_CHL_LB_HB_KIT_pck { get; set; }
        public virtual DbSet<siixsem_P42M_CHL_LDM_gb> siixsem_P42M_CHL_LDM_gb { get; set; }
        public virtual DbSet<siixsem_P42M_CHL_LDM_pck> siixsem_P42M_CHL_LDM_pck { get; set; }
        public virtual DbSet<siixsem_P42Q_RCL_AB_SAE_gb> siixsem_P42Q_RCL_AB_SAE_gb { get; set; }
        public virtual DbSet<siixsem_P42Q_RCL_AB_SAE_pck> siixsem_P42Q_RCL_AB_SAE_pck { get; set; }
        public virtual DbSet<siixsem_P42S_FCL_B_gb> siixsem_P42S_FCL_B_gb { get; set; }
        public virtual DbSet<siixsem_P42S_FCL_B_pck> siixsem_P42S_FCL_B_pck { get; set; }
        public virtual DbSet<siixsem_P702_LB_gb> siixsem_P702_LB_gb { get; set; }
        public virtual DbSet<siixsem_P702_LB_pck> siixsem_P702_LB_pck { get; set; }
        public virtual DbSet<siixsem_P758_CHL_B_gb> siixsem_P758_CHL_B_gb { get; set; }
        public virtual DbSet<siixsem_P758_CHL_B_pck> siixsem_P758_CHL_B_pck { get; set; }
        public virtual DbSet<siixsem_P758_CHL_C_gb> siixsem_P758_CHL_C_gb { get; set; }
        public virtual DbSet<siixsem_P758_CHL_C_pck> siixsem_P758_CHL_C_pck { get; set; }
        public virtual DbSet<siixsem_PMI_PCB_gb> siixsem_PMI_PCB_gb { get; set; }
        public virtual DbSet<siixsem_PMI_PCB_pck> siixsem_PMI_PCB_pck { get; set; }
        public virtual DbSet<siixsem_S550_FCL_FOG_gb> siixsem_S550_FCL_FOG_gb { get; set; }
        public virtual DbSet<siixsem_S550_FCL_FOG_pck> siixsem_S550_FCL_FOG_pck { get; set; }
        public virtual DbSet<siixsem_S550_gb> siixsem_S550_gb { get; set; }
        public virtual DbSet<siixsem_S550_pck> siixsem_S550_pck { get; set; }
        public virtual DbSet<siixsem_S650_611_gb> siixsem_S650_611_gb { get; set; }
        public virtual DbSet<siixsem_S650_611_pck> siixsem_S650_611_pck { get; set; }
        public virtual DbSet<siixsem_serials_blocked_t> siixsem_serials_blocked_t { get; set; }
        public virtual DbSet<siixsem_SUB_PCB_gb> siixsem_SUB_PCB_gb { get; set; }
        public virtual DbSet<siixsem_SUB_PCB_pck> siixsem_SUB_PCB_pck { get; set; }
        public virtual DbSet<siixsem_T20A_D_gb> siixsem_T20A_D_gb { get; set; }
        public virtual DbSet<siixsem_T20A_D_pck> siixsem_T20A_D_pck { get; set; }
        public virtual DbSet<siixsem_T20A_F_G_gb> siixsem_T20A_F_G_gb { get; set; }
        public virtual DbSet<siixsem_T20A_F_G_pck> siixsem_T20A_F_G_pck { get; set; }
        public virtual DbSet<siixsem_T5A_RCL_gb> siixsem_T5A_RCL_gb { get; set; }
        public virtual DbSet<siixsem_T5A_RCL_pck> siixsem_T5A_RCL_pck { get; set; }
        public virtual DbSet<siixsem_T7SA_SAE_gb> siixsem_T7SA_SAE_gb { get; set; }
        public virtual DbSet<siixsem_T7SA_SAE_pck> siixsem_T7SA_SAE_pck { get; set; }
        public virtual DbSet<siixsem_TG7X_CHL_LB_gb> siixsem_TG7X_CHL_LB_gb { get; set; }
        public virtual DbSet<siixsem_TG7X_CHL_LB_pck> siixsem_TG7X_CHL_LB_pck { get; set; }
        public virtual DbSet<siixsem_TJBA_FLF_LDM_gb> siixsem_TJBA_FLF_LDM_gb { get; set; }
        public virtual DbSet<siixsem_TJBA_FLF_LDM_pck> siixsem_TJBA_FLF_LDM_pck { get; set; }
        public virtual DbSet<siixsem_U625_FLF_gb> siixsem_U625_FLF_gb { get; set; }
        public virtual DbSet<siixsem_U625_FLF_pck> siixsem_U625_FLF_pck { get; set; }
        public virtual DbSet<siixsem_U725_CHMSL_gb> siixsem_U725_CHMSL_gb { get; set; }
        public virtual DbSet<siixsem_U725_CHMSL_pck> siixsem_U725_CHMSL_pck { get; set; }
        public virtual DbSet<siixsem_U725_FAN_gb> siixsem_U725_FAN_gb { get; set; }
        public virtual DbSet<siixsem_U725_FAN_pck> siixsem_U725_FAN_pck { get; set; }
        public virtual DbSet<siixsem_VP5_0_DIG_gb> siixsem_VP5_0_DIG_gb { get; set; }
        public virtual DbSet<siixsem_VP5_0_DIG_pck> siixsem_VP5_0_DIG_pck { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    }
}
