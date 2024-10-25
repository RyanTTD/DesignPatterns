import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './pages/home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { CoreService } from './services/core.service';
import { AdapterComponent } from './pages/design-patterns/structural/adapter/adapter.component';
import { FaIconLibrary, FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { fas } from '@fortawesome/free-solid-svg-icons';
import { BridgeComponent } from './pages/design-patterns/structural/bridge/bridge.component';
import { DecoratorComponent } from './pages/design-patterns/structural/decorator/decorator.component';
import { IkigaiComponent } from './pages/ikigai/ikigai.component';
import { TopMenuComponent } from './components/top-menu/top-menu.component';
import { CommandComponent } from './pages/design-patterns/behavioral/decorator/command.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    TopMenuComponent,
    HomeComponent,
    AdapterComponent,
    BridgeComponent,
    DecoratorComponent,
    CommandComponent,
    CounterComponent,
    FetchDataComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'designpatterns/structural/adapter', component: AdapterComponent },
      { path: 'designpatterns/structural/bridge', component: BridgeComponent },
      { path: 'designpatterns/structural/decorator', component: DecoratorComponent },
      { path: 'designpatterns/behavioral/command', component: CommandComponent },
      { path: 'ikigai', component: IkigaiComponent },
    ]),
    FontAwesomeModule
  ],
  providers: [CoreService],
  bootstrap: [AppComponent]
})
export class AppModule {
  constructor(library: FaIconLibrary) {
    library.addIconPacks(fas);
  }
}
