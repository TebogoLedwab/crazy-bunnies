(() => {
  if (matchMedia('(prefers-reduced-motion: reduce)').matches) return;
  let y = 0, ticking = false, els = [];
  const apply = () => {
    els.forEach(el => { const d = parseFloat(el.dataset.depth); el.style.transform = `translate3d(0,${(y * d).toFixed(1)}px,0)`; });
    ticking = false;
  };
  const init = () => { els = [...document.querySelectorAll('[data-depth]')]; apply(); };
  addEventListener('scroll', () => { y = Math.min(scrollY, innerHeight * 1.2); if (!ticking) { ticking = true; requestAnimationFrame(apply); } }, { passive: true });
  new MutationObserver(init).observe(document.body, { childList: true, subtree: true });
  addEventListener('load', init);
})();
