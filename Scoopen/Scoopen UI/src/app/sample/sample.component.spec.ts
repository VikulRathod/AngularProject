import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SampleComponent } from './sample.component';

describe('SampleComponent', () => {
  let component: SampleComponent;
  let fixture: ComponentFixture<SampleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SampleComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SampleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it(`should have as userName 'Vishal'`, () => {
    const fixture = TestBed.createComponent(SampleComponent);
    const app = fixture.componentInstance;
    expect(app.userName).toEqual('Mahesh');
  });

  it(`add function testing`, () => {
    const fixture = TestBed.createComponent(SampleComponent);
    const app = fixture.componentInstance;
    expect(app.add(10,10)).toEqual(200);
  });
});
