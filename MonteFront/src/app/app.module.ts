import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http'
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
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { LeaveFormComponent } from './_Forms/leave-form/leave-form.component';
import { EmployeeAwardFormComponent } from './_Forms/employee-award-form/employee-award-form.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';

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
    SpiritualCulturalComponent,
    LeaveFormComponent,
    EmployeeAwardFormComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    BsDropdownModule.forRoot(),
    BsDatepickerModule.forRoot()
  ],
  exports: [
    BsDropdownModule,
    BsDatepickerModule,
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
