  <template>
    <div class="persons mt-3">
        <input type="text" v-model="Id" > 
        <p v-for="person in persons" class="txt-name"> Id:  {{person.id}} Name:  {{person.name}} Address: {{person.address}}</p>
      <hr />
      <div >
        <button v-on:click="LoadData">Submit</button>
      </div>
    </div>
  </template>

  <script>
    export default {
    data() {
        return {
          persons: [],
          Id: null,
        };
      },
      methods: {
        LoadData: function () {
          //parameter
          var params = new URLSearchParams();
          params.append("Id", this.Id);
          var request = {
            params: params
          };
          try {
            //Need to match the route path
            this.$http.get('/api/Persons/', request).then(results => {
              this.persons = results.data;
            });

          } catch (error) {
            alert("Item not found");
            console.log(error)
          }
        }
      },
      //Load the data on load
      created: function () {
        this.LoadData();
      }

    };
  </script>


