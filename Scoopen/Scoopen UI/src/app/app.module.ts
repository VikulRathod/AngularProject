import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';

// used to create fake backend
//import { fakeBackendProvider } from 'src/app/core/services/data-provider.service';

import { AppRoutingModule } from './app-routing.module';
import { ErrorInterceptorService } from 'src/app/core/services/error-interceptor.service';
import { AppComponent } from './app.component';
import { HomeComponent } from 'src/app/home/home.component';
import { CoreModule } from './core/core.module';
import { BlocksModule } from './blocks/blocks.module';
import { SampleComponent } from './sample/sample.component';

@NgModule({
    imports: [
        BrowserModule,
        CoreModule,
        BlocksModule,
        ReactiveFormsModule,
        HttpClientModule,
        AppRoutingModule        
    ],
    declarations: [
        AppComponent,
        HomeComponent,
        SampleComponent
    ],
    providers: [
        { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptorService, multi: true }
        
        // provider used to create fake backend
        //fakeBackendProvider
    ],
    bootstrap: [AppComponent]
})
export class AppModule { };