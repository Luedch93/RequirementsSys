import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { StoreModule } from '@ngrx/store';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { FormTypeComponent } from './form-type/form-type.component';
import { TypeListComponent } from './type-list/type-list.component';
import { typeReducer } from './reducers/type.reducer';
import { EffectsModule } from '@ngrx/effects';
import { TypeEffect } from './effects/type.effect';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    FormTypeComponent,
    TypeListComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'type/new', component: FormTypeComponent },
      { path: 'type/list', component: TypeListComponent },
    ]),
    StoreModule.forRoot({ types: typeReducer}),
    EffectsModule.forRoot([TypeEffect])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
