
import { defineComponent } from "vue";
import NoteComponent from "../Note/Note";

type Notes = {
  id: number;
  name: string;
  content: string;
  color: string;
}[];

interface Data {
  loading: boolean;
  post: null | Notes;
}

export default defineComponent({
    components: {NoteComponent},
  data(): Data {
    return {
      loading: false,
      post: null,
    };
  },
  template: `<div>Note Component 
  <div v-if="post" class="content"  v-for="item in post">
   <NoteComponent :data=item />
</div>  
</div>`,
  // props:{
  //   loading: false,
  //   post: null

  // },
  created() {this.fetchData();},
  //components:{NoteComponent},
  watch: {
    // call again the method if the route changes
    $route: "fetchData",
  },
  methods: {
    fetchData(): void {
      
      this.post = null;
      this.loading = true;

      fetch("note")
        .then((r) => r.json())
        .then((json) => {
          this.post = json as Notes;
          this.loading = false;
          return;
        });
    },
  },
})
