import { Directive, ElementRef, HostBinding, HostListener, Input, OnChanges, Renderer2 } from '@angular/core';

@Directive({
  selector: '[appHighlight]',
  exportAs: 'appHighlight'
})
export class HighlightDirective implements OnChanges{

  @HostBinding('class.is-highlighted') get isHighlighted() {
    return this.appHighlight;
  }

  @Input() color = 'green';

  // @Input() isHighlighted = false;
  @Input() appHighlight = false;

  @HostListener('mouseenter', ['$event']) onMouseEnter(e: any) {
    console.log(e);
    if (this.appHighlight) {
        return;
    }
    this.appHighlight = !this.appHighlight;
    this.highlight();
  }

  @HostListener('mouseleave') onMouseLeave() {
    if (!this.appHighlight) {
        return;
    }
    this.appHighlight = !this.appHighlight;
    this.highlight();
  }

  constructor(
    private renderer: Renderer2,
    private elementRef: ElementRef
    ) { }

  highlight() {
    this.renderer.setStyle(
      this.elementRef.nativeElement,
      'backgroundColor',
      this.appHighlight ? this.color : 'inherit'
    )
  }

  ngOnChanges(): void {
    this.highlight();
  }
}
