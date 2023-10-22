import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';
import { TeamListComponent } from './components/teamlist.component';
import { TeamComponent } from './components/team/team.component';
import { TestingComponent } from './components/testing/testing.component';

@NgModule({
  declarations: [
    AppComponent,
    TeamListComponent,
    TeamComponent,
    TestingComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]  //root(start up) component is marked here
})
export class AppModule { }
