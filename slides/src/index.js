import Reveal from 'reveal.js';
import markdown from 'reveal.js/plugin/markdown/markdown';
import highlight from 'reveal.js/plugin/highlight/highlight';
import notes from 'reveal.js/plugin/notes/notes';
import zoom from 'reveal.js/plugin/zoom/zoom';
import search from 'reveal.js/plugin/search/search';
import mermaid from 'reveal.js-mermaid-plugin';

let deck = new Reveal({
  plugins: [markdown, highlight, notes, zoom, search, mermaid]
})

deck.initialize({
  hash: true
});
