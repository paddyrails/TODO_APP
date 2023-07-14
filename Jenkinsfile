pipeline {
  agent any

  stages {
    stage("Clean Up"){
      steps {
        deleteDir()
      }
    }
     stage("Clone Repo"){
      steps {
        sh "git clone https://github.com/paddyrails/TODO_APP.git"
      }
    }
    stage("Build"){
      steps {
        dir("TODO_APP"){
          echo "Running build.."          
        }
      }
    }
  }
}
