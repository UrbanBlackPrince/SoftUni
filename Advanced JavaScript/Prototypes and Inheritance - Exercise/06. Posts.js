function solution(){
    class Post {
        constructor(title, content) {
            this.title = title;
            this.content = content;
        }
        toString(){
            return `Post: ${this.title}\nContent: ${this.content}`;
        }
    }

    class SocialMediaPost extends Post {
        constructor(title, content, likes, dislikes) {
            super(title, content)
            this.likes = Number(likes);
            this.dislikes = Number(dislikes);
            this.comments = [];
        }

        addComment(comment){
            this.comments.push(comment);
        }
        toString(){
            if (this.comments.length == 0) {
                return `${super.toString()}\nRating: ${this.likes - this.dislikes}`;
            } else {
                let commentSection = this.comments.map(x => ` * ${x}`).join('\n');
            
                return `${super.toString()}\nRating: ${this.likes - this.dislikes}\nComments:\n${commentSection}`;
            }   
        }
    }

    class BlogPost extends Post {
        constructor(title, content, views) {
            super(title, content)
            this.views = Number(views);
        }

        view(){
            this.views++;
            return this;
        }
        toString(){
            return `${super.toString()}\nViews: ${this.views}`;
        }
    }
    
    return { Post, SocialMediaPost, BlogPost };
}