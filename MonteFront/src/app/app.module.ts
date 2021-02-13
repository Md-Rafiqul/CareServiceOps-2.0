import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AccountComponent } from './account/account.component';
import { HomeComponent } from './home/home.component';
import { NavComponent } from './nav/nav.component';
import { AlliedHealthServicesComponent } from './allied-health-services/allied-health-services.component';
import { ResidentialCareComponent } from './residential-care/residential-care.component';
import { AdmissionComponent } from './admission/admission.component';
import { CustomerAssuranceComponent } from './customer-assurance/customer-assurance.component';
import { ClinicalResourceComponent } from './clinical-resource/clinical-resource.component';
import { PeopleCultureLearningComponent } from './people-culture-learning/people-culture-learning.component';
import { FinanceComponent } from './finance/finance.component';
import { FoundationComponent } from './foundation/foundation.component';
import { HotelServicesComponent } from './hotel-services/hotel-services.component';
import { ITComponent } from './it/it.component';
import { MaintenanceComponent } from './maintenance/maintenance.component';
import { MarketingComponent } from './marketing/marketing.component';
import { VolunteersComponent } from './volunteers/volunteers.component';
import { SpiritualCulturalComponent } from './spiritual-cultural/spiritual-cultural.component';

@NgModule({
  declarations: [
    AppComponent,
    AccountComponent,
    HomeComponent,
    NavComponent,
    AlliedHealthServicesComponent,
    ResidentialCareComponent,
    AdmissionComponent,
    CustomerAssuranceComponent,
    ClinicalResourceComponent,
    PeopleCultureLearningComponent,
    FinanceComponent,
    FoundationComponent,
    HotelServicesComponent,
    ITComponent,
    MaintenanceComponent,
    MarketingComponent,
    VolunteersComponent,
    SpiritualCulturalComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
